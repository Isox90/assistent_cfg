//Adding support for Chrome DevTools Protocol in Selenium 3.x

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.WebSockets;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WebPrintToPdf {
	class Program {
		static void Main(string[] args) {
			var service = ChromeDriverService.CreateDefaultService(@"C:\Program Files\ChromeDriver", "chromedriver.exe");

			ChromeOptions options = new ChromeOptions();
			if (System.IO.File.Exists(@"C:\Program Files\Google\Chrome\Application\chrome.exe")) {
				options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
			}
			options.AddUserProfilePreference("download.default_directory", Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads"));
			//options.AddArgument(@"remote-allow-origins=http://127.0.0.1:2137"); //frontend debug approve
			options.AddArgument("remote-debugging-port=2137");
			options.AddArgument("headless");
			

			ChromeDriver driver = new ChromeDriver(service, options);
			driver.Manage().Window.Maximize();
			
			try {
				driver.Navigate().GoToUrl(@"https://wyszukiwarkaregon.stat.gov.pl/appBIR/index.aspx");
				while(driver.FindElementsById("txtRegon").Count < 0){}
				Thread.Sleep(1000);
				driver.FindElementById("txtRegon").SendKeys("610188201");
				Thread.Sleep(1000);
				driver.FindElementById("btnSzukaj").Click();
				while(driver.FindElementsByXPath("//div[@id='divListaJednostek']//a").Count < 0){}
				Thread.Sleep(1000);
				driver.FindElementsByXPath("//div[@id='divListaJednostek']//a")[0].Click();
				while(driver.FindElementsById("tblRaportJPrawna").Count < 0){}
				
				var taskWebConnect = Task.Run(() => GeneratePdf());
				taskWebConnect.Wait();

			}catch (Exception e) {
				Console.WriteLine(e.ToString());
			}finally {
				//Console.ReadLine();
				driver.Quit();
			}
		}

		private static async Task GeneratePdf() {
			string cdpWsAddress = string.Empty;
			string json = string.Empty;
			using (WebClient webClient = new WebClient()) {
				ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
				ServicePointManager.DefaultConnectionLimit = 9999;
				webClient.Proxy = System.Net.WebRequest.DefaultWebProxy;
				webClient.Credentials = System.Net.CredentialCache.DefaultCredentials;
				webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
				webClient.Encoding = System.Text.Encoding.UTF8;

				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12");
				json = webClient.DownloadString(@"http://127.0.0.1:2137/json");
			}
			var response = JsonConvert.DeserializeObject<dynamic>(json);
			cdpWsAddress = (string)response[0].webSocketDebuggerUrl;

			string outputJson = string.Empty;
			using (ClientWebSocket ws = new ClientWebSocket()) {
				Uri serverUri = new Uri(cdpWsAddress);
				await ws.ConnectAsync(serverUri, CancellationToken.None);

				while (ws.State == WebSocketState.Open) {
					//string msg = "{\"id\": 2137,\"method\": \"Page.printToPDF\",\"params\": {}}";
					string msg = "{\"id\": 2137,\"method\": \"Page.printToPDF\",\"params\": {\"paperWidth\": 8.25, \"paperWidth\": 11.7, \"scale\": 0.9}}";
					
					ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));
					await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);

					ArraySegment<Byte> buffer = new ArraySegment<byte>(new Byte[8192]);
					WebSocketReceiveResult result = null;
					using (var ms = new MemoryStream()) {
					    do {
					        result = await ws.ReceiveAsync(buffer, CancellationToken.None);
					        ms.Write(buffer.Array, buffer.Offset, result.Count);
					    }
					    while (!result.EndOfMessage);
						outputJson = Encoding.ASCII.GetString(ms.ToArray());
					}
					break;
				}
			}
			var outputObject = JsonConvert.DeserializeObject<dynamic>(outputJson);
			string byte64string = (string)outputObject.result.data;

			string path = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads", "WebPdfFileOutput.pdf");
			File.WriteAllBytes(path, Convert.FromBase64String(byte64string));
		}
    }
}
