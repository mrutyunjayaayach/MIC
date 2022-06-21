using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC
{
    [TestFixture]
    public class ExtentManager
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IWebDriver driver;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static ExtentTest test;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static ExtentReports extent;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }


        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"E:\ITPlusPoint\AutomationTesting\Sample_Proj2\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);

        }



        [Test]
        public void BrowserTest()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            test = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            test = extent.CreateTest("T001").Info("Login Test");

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");
            test.Log(Status.Info, "Go to URL");

            //provide username
            driver.FindElement(By.Id("usr")).SendKeys("admin");
            //provide password
            driver.FindElement(By.Id("pwd")).SendKeys("12345");
        }

        [TearDown]
        public void closeBrowser()
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