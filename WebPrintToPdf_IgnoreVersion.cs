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
using OpenQA.Selenium.Remote;
using System.Diagnostics;

namespace ChromeDriverUnversioner
{
    internal class Program
    {
        static string driverPort = "9555";
        static string browserPort = "2137";

        static void Main(string[] args)
        {
            //current 131
            //tested versions 115-133
            //from 119 everything works
            //32 bits doesnt work in my env
            Console.WriteLine(Environment.GetEnvironmentVariable("USERPROFILE"));

            List<string> folderPaths = GetExeFilesRecursive($@"{Environment.GetEnvironmentVariable("USERPROFILE")}\Downloads\chromedrivers"); //example path => chromedrivers/chromedriver_131.0.6778.85_64/chromedriver-win64/chromedriver.exe

            foreach (string path in folderPaths)
            {
                ClearChromedrivers();

                string name = path.Substring(path.LastIndexOf("chromedriver_") + 13, 3);
                if (path.Contains("_32"))
                {
                    name += "_32";
                    continue;
                }
                else
                    name += "_64";
                try
                {
                    Runner(Path.GetDirectoryName(path), name);
                } catch
                {
                    Console.WriteLine("error");
                }
            }

            ClearChromedrivers();
            Console.WriteLine("done");
            Console.ReadLine();
        }

        public static void Runner(string path, string name)
        {
            Console.WriteLine(name);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C chromedriver.exe --port={driverPort} --disable-build-check"; //unsupported selenium 3 magic
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = path;
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(2000);

            ChromeOptions options = new ChromeOptions();
            if (System.IO.File.Exists(@"C:\Program Files\Google\Chrome\Application\chrome.exe"))
            {
                options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            }
            options.AddUserProfilePreference("download.default_directory", Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads"));
            options.AddArgument($"remote-debugging-port={browserPort}");
            options.AddArgument("headless");

            Uri uri = new Uri($@"http://127.0.0.1:{driverPort}/");
            RemoteWebDriver driver = new RemoteWebDriver(uri, options);

            try
            {
                driver.Navigate().GoToUrl(@"https://wyszukiwarkaregon.stat.gov.pl/appBIR/index.aspx");
                while (driver.FindElementsById("txtRegon").Count < 0) { }
                Thread.Sleep(1000);
                driver.FindElementById("txtRegon").SendKeys("610188201");
                Thread.Sleep(1000);
                driver.FindElementById("btnSzukaj").Click();
                while (driver.FindElementsByXPath("//div[@id='divListaJednostek']//a").Count < 0) { }
                Thread.Sleep(1000);
                driver.FindElementsByXPath("//div[@id='divListaJednostek']//a")[0].Click();
                while (driver.FindElementsById("tblRaportJPrawna").Count < 0) { }

                var taskWebConnect = Task.Run(() => GeneratePdf(name));
                taskWebConnect.Wait();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }

        private static async Task GeneratePdf(string name)
        {
            string cdpWsAddress = string.Empty;
            string json = string.Empty;
            using (WebClient webClient = new WebClient())
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                ServicePointManager.DefaultConnectionLimit = 9999;
                webClient.Proxy = System.Net.WebRequest.DefaultWebProxy;
                webClient.Credentials = System.Net.CredentialCache.DefaultCredentials;
                webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                webClient.Encoding = System.Text.Encoding.UTF8;

                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12");
                json = webClient.DownloadString($@"http://127.0.0.1:{browserPort}/json");
            }
            var response = JsonConvert.DeserializeObject<dynamic>(json);
            cdpWsAddress = (string)response[0].webSocketDebuggerUrl;

            string outputJson = string.Empty;
            using (ClientWebSocket ws = new ClientWebSocket())
            {
                Uri serverUri = new Uri(cdpWsAddress);
                await ws.ConnectAsync(serverUri, CancellationToken.None);

                while (ws.State == WebSocketState.Open)
                {
                    string msg = "{\"id\": 69,\"method\": \"Page.printToPDF\",\"params\": {\"paperWidth\": 8.25, \"paperWidth\": 11.7, \"scale\": 0.9}}";

                    ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));
                    await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);

                    ArraySegment<Byte> buffer = new ArraySegment<byte>(new Byte[8192]);
                    WebSocketReceiveResult result = null;
                    using (var ms = new MemoryStream())
                    {
                        do
                        {
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

            string path = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads", $"WebPdfFileOutput_{name}.pdf");
            File.WriteAllBytes(path, Convert.FromBase64String(byte64string));
        }

        public static List<string> GetExeFilesRecursive(string directoryPath)
        {
            List<string> exeFiles = new List<string>();

            try
            {
                string[] files = Directory.GetFiles(directoryPath, "*.exe");
                exeFiles.AddRange(files);

                string[] directories = Directory.GetDirectories(directoryPath);
                foreach (string subdirectory in directories)
                {
                    exeFiles.AddRange(GetExeFilesRecursive(subdirectory));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accessing directory: " + ex.Message);
            }

            return exeFiles;
        }

        public static void ClearChromedrivers()
        {
            Process[] processes = Process.GetProcessesByName("chromedriver");
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                }
                catch { }
            }
        }
    }
}
