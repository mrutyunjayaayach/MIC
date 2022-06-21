using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MIC
{
    [TestFixture]
    public class File_A_Claim
    {
        public IWebDriver driver;
        public static ExtentTest test;
        public static ExtentReports extent;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        //[SetUp]
        //public void Setup()
        //{
        //    //driver = new ChromeDriver();
        //    //driver.Navigate().GoToUrl("http://staging.mic.dev2stage.in/");
        //    //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //    //String Title = driver.Title;
        //    //Console.WriteLine(Title);
        //    //driver.Manage().Window.Maximize();
        //}
        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"E:\ITPlusPoint\AutomationTesting\Sample_Proj2\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);

        }

        [Test]
        public void File_Claim()
        {
            test = null;
            test = extent.CreateTest("T001").Info("File A Claim Test");
            driver.Navigate().GoToUrl("http://staging.mic.dev2stage.in/");
            test.Log(Status.Info, "Go to URL");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            String Title = driver.Title;
            Console.WriteLine(Title);
            driver.Manage().Window.Maximize();
            test.Log(Status.Info, "Window Maximize");
            IWebElement ele = driver.FindElement(By.Id("EmailId"));
            ele.SendKeys("komalshan98769@gmail.com");
            test.Log(Status.Info, "Email Id Entered");
            Console.Write("username value is entered \n");
            IWebElement ele1 = driver.FindElement(By.Id("Login_Password"));
            ele1.SendKeys("Itpp@1234");
            test.Log(Status.Info, "Password Entered");
            Console.Write("password is entered \n");
            IWebElement ele2 = driver.FindElement(By.XPath("//body/div[1]/form[1]/div[1]/div[1]/div[1]/div[4]/button[1]"));
            ele2.Click();
            test.Log(Status.Info, "Login button Clicked");
            Console.Write("login button is clicked \n");
            driver.FindElement(By.XPath("//label[contains(text(),'Claims')]")).Click();
            Thread.Sleep(5000);
            test.Log(Status.Info, "Open Claim");
            driver.FindElement(By.XPath("//a[contains(text(),'File a Claim')]")).Click();
            Thread.Sleep(1000);
            test.Log(Status.Info, "Click on File a Claim");
            driver.Navigate().Refresh();
            WebElement element5 = (WebElement)driver.FindElement(By.XPath("//input[@id='exampleDataList']"));
            element5.Click();
            element5.SendKeys("Absa");
            test.Log(Status.Info, "Enter Service Provider Name");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//li[contains(text(),'Absa Group Limited SF (1111)')]")).Click();
            Thread.Sleep(5000);
            test.Log(Status.Info, "Select Service Provider");
            driver.FindElement(By.XPath("//button[@id='BTN_GET_DETAILS']")).Click();
            test.Log(Status.Info, "Click on Get Details");
            Thread.Sleep(1000);
            IWebElement Element1 = driver.FindElement(By.XPath("//button[@id='NXTBTN']"));
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("arguments[0].scrollIntoView();", Element1);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            test.Log(Status.Info, "Click on Next Button");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='Search_Membership_Id']")).SendKeys("M000000004");
            test.Log(Status.Info, "Membership Id entered");
            driver.FindElement(By.XPath("//button[contains(text(),'Get Details')]")).Click();
            test.Log(Status.Info, "Click on Get Details");
            Thread.Sleep(1000);
            IWebElement Element = driver.FindElement(By.Id("NXTBTN"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            test.Log(Status.Info, "Click on Next Button");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Row_1")).Click();
            driver.FindElement(By.Id("Row_2")).Click();
            test.Log(Status.Info, "Select Beneficiary");
            driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[3]/button[1]/img[1]")).Click();
            test.Log(Status.Info, "Click on Save");
            Thread.Sleep(1000);
            IAlert confirmationAlert = driver.SwitchTo().Alert();
            String alertText = confirmationAlert.Text;
            Console.WriteLine("Alert text is " + alertText);
            confirmationAlert.Accept();
            test.Log(Status.Info, "Conformation Alert Accept");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            test.Log(Status.Info, "Click on Next");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            test.Log(Status.Info, "Click on Next");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Doctor_Name")).SendKeys("Seeak Asthana");
            test.Log(Status.Info, "Docton Name Entered");
            driver.FindElement(By.Id("Doctor_Reg_Number")).SendKeys("202256955");
            test.Log(Status.Info, "Practice No. Entered");
            //Thread.Sleep(5000);
            //IWebElement Element9 = driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[2]/div[5]/div[4]/button[1]"));
            //IJavaScriptExecutor js9 = (IJavaScriptExecutor)driver;
            //js9.ExecuteScript("arguments[0].scrollIntoView();", Element9);
            driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[2]/div[5]/div[4]/button[1]")).Click();
            test.Log(Status.Info, "Click on Add");
            IWebElement Element3 = driver.FindElement(By.XPath("//button[@id='NXTBTN']"));
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript("arguments[0].scrollIntoView();", Element3);
            Thread.Sleep(5000);
            WebElement ele4 = (WebElement)driver.FindElement(By.Id("ICD_Code"));
            ele4.SendKeys("f");
            test.Log(Status.Info, "ICD Code Entered");
            ele4.Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[2]/div[7]/div[1]/div[1]/div[1]/ul[1]/li[3]")).Click();
            test.Log(Status.Info, "ICD Code Selected");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[2]/div[7]/div[3]/button[1]")).Click();
            test.Log(Status.Info, "Click on Add");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            test.Log(Status.Info, "Click on Next");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Sp_Invoice_Number")).SendKeys("732568");
            test.Log(Status.Info, "Invoice Number Entered");
            SelectElement select = new SelectElement(driver.FindElement(By.Id("Beneficiary_Id")));
            select.SelectByText("Bearry Newbarry (PM)");
            test.Log(Status.Info, "Beneficiary Selected");
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("Discipline_Id")));
            select1.SelectByText("014 - General Practitioner");
            test.Log(Status.Info, "Discipline Id Selected");
            WebElement tariff = (WebElement)driver.FindElement(By.Id("TariffCode"));
            tariff.SendKeys("0");
            tariff.Click();
            test.Log(Status.Info, "Tariff Code Entered");
            Thread.Sleep(5000);
            IWebElement Element9 = driver.FindElement(By.XPath("//li[contains(text(),'0113 - New born attendance: Emergency attendance t')]"));
            IJavaScriptExecutor js9 = (IJavaScriptExecutor)driver;
            js9.ExecuteScript("arguments[0].scrollIntoView();", Element9);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//li[contains(text(),'0113 - New born attendance: Emergency attendance t')]")).Click();
            test.Log(Status.Info, "Tariff Code Selected");
            driver.FindElement(By.Id("Claim_Amount")).SendKeys("500");
            test.Log(Status.Info, "Claim Amount Entered");
            driver.FindElement(By.Id("TRTM_BTN")).Click();
            test.Log(Status.Info, "Iteam Details Added");
            //Thread.Sleep(5000);
            //driver.FindElement(By.Id("SAVEBTN")).Click();
            Thread.Sleep(5000);
            IWebElement Element18 = driver.FindElement(By.XPath("//button[@id='SBTN']"));
            IJavaScriptExecutor js18 = (IJavaScriptExecutor)driver;
            js18.ExecuteScript("arguments[0].scrollIntoView();", Element18);
            Thread.Sleep(5000);
            driver.FindElement(By.Id("SBTN")).Click();
            test.Log(Status.Info, "Click on Submit Button");
            Thread.Sleep(1000);
            Assert.That("http://staging.mic.dev2stage.in/MediClaim/ListClaim", Is.EqualTo("http://staging.mic.dev2stage.in/MediClaim/ListClaim"));
            test.Log(Status.Info, "Verifing URL");
            Console.WriteLine("Succssfully File a Claim");
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
    }
}