using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MIC
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {

            driver.Navigate().GoToUrl("http://staging.mic.dev2stage.in/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            String Title = driver.Title;
            Console.WriteLine(Title);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement ele = driver.FindElement(By.Id("EmailId"));
            ele.SendKeys("komalshan98769@gmail.com");
            Console.Write("username value is entered \n");
            IWebElement ele1 = driver.FindElement(By.Id("Login_Password"));
            ele1.SendKeys("Itpp@1234");
            Console.Write("password is entered \n");
            IWebElement ele2 = driver.FindElement(By.XPath("//body/div[1]/form[1]/div[1]/div[1]/div[1]/div[4]/button[1]"));
            ele2.Click();
            Console.Write("login button is clicked \n");
            driver.FindElement(By.XPath("//label[contains(text(),'Service Providers')]")).Click();
            Thread.Sleep(5000);
            WebElement driver6 = (WebElement)driver.FindElement(By.XPath("//th[contains(text(),'Practice Number')]"));
            string data = driver6.Text;
            Console.WriteLine("Datas are /n" + data);
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}