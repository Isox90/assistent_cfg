// PL Account number extractor for Nip, Regon, Krs, PKD

using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace IbanScrapper
{
    internal class Program
    {
        static ChromeDriver driver;
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                while (true)
                {
                    Subject client = new Subject();
                    Console.Clear();

                    Console.Write("Wprowadź numer konta: ");
                    client.AccountNumber = Console.ReadLine().Replace(" ", "");
                    Console.WriteLine();

                    bool success = false;
                    for(int i = 0; i <= 10; i++)
                    {
                        if (ProcessWykazPodatnikowVAT(client))
                        {
                            break;
                        }
                    }
                    for (int i = 0; i <= 10; i++)
                    {
                        if (ProcessRegon(client))
                        {
                            success = true;
                            break;
                        }
                    }


                    if (success)
                    {
                        Console.WriteLine("Regon: " + client.Regon);
                        Console.WriteLine("Nip: " + client.Nip);
                        Console.WriteLine("Krs: " + client.Krs);
                        Console.WriteLine("PKD główne:");
                        foreach (string pkd in client.PkdMain)
                        {
                            Console.WriteLine(pkd);
                        }

                        Console.WriteLine("PKD dodatkowe:");
                        foreach (string pkd in client.PkdAdditional)
                        {
                            Console.WriteLine(pkd);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                    Console.ReadLine();
                }
            }
            catch
            {
                driver.Close();
                driver.Quit();
            }
        }

        private static bool ProcessWykazPodatnikowVAT(Subject client)
        {
            try
            {
                driver.Navigate().GoToUrl(@"https://www.podatki.gov.pl/wykaz-podatnikow-vat-wyszukiwarka");
                IWebElement element = driver.FindElement(By.Id("inputType"));
                foreach(char c in client.AccountNumber)
                {
                    element.SendKeys(c.ToString());
                    Thread.Sleep(10);
                }
                element.SendKeys(OpenQA.Selenium.Keys.Enter);

                driver.FindElement(By.XPath("//div[@id='tableOne']//h4"));

                client.Regon = driver.FindElement(By.XPath("//div[@id='tableOne']//td[contains(text(), 'REGON')]/following-sibling::td")).Text;
                client.Nip = driver.FindElement(By.XPath("//div[@id='tableOne']//td[contains(text(), 'zidentyfikowany na potrzeby podatku')]/following-sibling::td")).Text;
                client.Krs = driver.FindElement(By.XPath("//div[@id='tableOne']//td[contains(text(), 'Numer w Krajowym Rejestrze Sądowym')]/following-sibling::td")).Text;

                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static bool ProcessRegon(Subject client)
        {
            try
            {
                driver.Navigate().GoToUrl(@"https://wyszukiwarkaregon.stat.gov.pl/appBIR/index.aspx");
                IWebElement element;
                element = driver.FindElement(By.Id("tblWyszukiwaniePoIdentyfikatorze"));
                Thread.Sleep(250);

                if (!string.IsNullOrEmpty(client.Regon))
                {
                    foreach (char c in client.Regon)
                    {
                        element.FindElement(By.Id("txtRegon")).SendKeys(c.ToString());
                        Thread.Sleep(10);
                    }
                }
                else if (!string.IsNullOrEmpty(client.Nip))
                {
                    foreach (char c in client.Nip)
                    {
                        element.FindElement(By.Id("txtNip")).SendKeys(c.ToString());
                        Thread.Sleep(10);
                    }
                }
                else if (!string.IsNullOrEmpty(client.Krs))
                {
                    foreach (char c in client.Krs)
                    {
                        element.FindElement(By.Id("txtKrs")).SendKeys(c.ToString());
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    throw new Exception("brak danych");
                }

                Thread.Sleep(250);
                driver.FindElement(By.Id("btnSzukaj")).Click();
                driver.FindElements(By.XPath("//div[@id='divListaJednostek']//a[contains(@href, 'danePobierzPelnyRaport')]"))[0].Click();
                driver.FindElement(By.XPath("//strong[contains(text(), 'PKD')]/parent::td/following-sibling::td/div/input[@type='button' and contains(@onclick, 'danePobierzPelnyRaport')]")).Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                var tablePkdMain = driver.FindElements(By.XPath("//strong[contains(text(), 'PKD')]/parent::td/following-sibling::td/div/input[@type='button' and contains(@onclick, 'danePobierzPelnyRaport')]/ancestor::tbody//table[@class='tabelaZbiorcza tabelaZbiorczaPKD'][1]/tbody/tr"));
                var tablePkdAdditional = driver.FindElements(By.XPath("//strong[contains(text(), 'PKD')]/parent::td/following-sibling::td/div/input[@type='button' and contains(@onclick, 'danePobierzPelnyRaport')]/ancestor::tbody//table[@class='tabelaZbiorcza tabelaZbiorczaPKD'][2]/tbody/tr"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                List<string> tempPkdMain = new List<string>();
                List<string> tempPkdAdditional = new List<string>();

                foreach (var tr in tablePkdMain)
                {
                    string pkd = string.Empty;
                    pkd = tr.FindElements(By.TagName("td"))[0].Text + " - " + tr.FindElements(By.TagName("td"))[1].Text;
                    tempPkdMain.Add(pkd);
                }

                foreach (var tr in tablePkdAdditional)
                {
                    string pkd = string.Empty;
                    pkd = tr.FindElements(By.TagName("td"))[0].Text + " - " + tr.FindElements(By.TagName("td"))[1].Text;
                    tempPkdAdditional.Add(pkd);
                }
                client.PkdMain = tempPkdMain;
                client.PkdAdditional = tempPkdAdditional;

                return true;
            }catch(Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public class Subject
        {
            public string AccountNumber { get; set; }
            public string Nip { get; set; }
            public string Regon { get; set; }
            public string Krs { get; set; }
            public List<string> PkdMain { get; set; }
            public List<string> PkdAdditional { get; set; }
        }
    }
}
