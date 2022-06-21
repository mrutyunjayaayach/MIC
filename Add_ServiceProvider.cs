using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MIC
{
    internal class Add_ServiceProvider
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("http://staging.mic.dev2stage.in/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            String Title = driver.Title;
            Console.WriteLine(Title);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Add_Service_Provider()
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
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[contains(text(),'Add Service Provider')]")).Click();
//            //driver.FindElement(By.Id("Sp_Name")).SendKeys("SAI HEALTHCARE");

//            //Console.WriteLine("Enter Your Service Provider Name");
//            Console.WriteLine("Enter Your Service Provider Name:");
//            Thread.Sleep(1000);
//#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
//            string Name = Console.ReadLine();
//#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
//            Console.WriteLine("Username is: " + Name);
//            Thread.Sleep(1000);
            driver.FindElement(By.Id("Sp_Name")).SendKeys("SSF Association");
            Thread.Sleep(1000);
            WebElement driver4 = (WebElement)driver.FindElement(By.Id("Contact_Number_Work"));
            Random randomGenerator2 = new Random();
            int randomInt2 = (int)randomGenerator2.NextInt64(1000);
            driver4.SendKeys("063225" + randomInt2 + "8653");
            WebElement driver2 = (WebElement)driver.FindElement(By.Id("Email_Id"));
            driver2.Click();
            Random randomGenerator = new Random();
            int randomInt = (int)randomGenerator.NextInt64(1000);
            driver2.SendKeys("username" + randomInt + "@gmail.com");
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Practice_Type_Id']")));
            oSelect1.SelectByText("Dentist");
            WebElement driver3 = (WebElement)driver.FindElement(By.Id("Practice_Number"));
            Random randomGenerator1 = new Random();
            int randomInt1 = (int)randomGenerator1.NextInt64(1000);
            driver3.SendKeys("732" + randomInt1 + "586");
            driver.FindElement(By.XPath("//input[@id='Registration_Date']")).Click();
            SelectElement oSelect3 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[2]")));
            oSelect3.SelectByText("2022");
            SelectElement oSelect2 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[1]")));
            oSelect2.SelectByText("Jan");
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[1]")).Click();
            IWebElement wb = driver.FindElement(By.XPath("//input[@id='wizardpicture']"));
            wb.SendKeys("C:\\Users\\mruty\\Downloads\\6da30596-d6b1-4474-bbde-c4cf4b411460 (1).jpg");
            driver.FindElement(By.Id("Physical_Address")).SendKeys("1951 Uitsig St");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Physical_City")).SendKeys("Bathurst");
            Thread.Sleep(5000);
            SelectElement oSelect4 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Physical_Country_Id']")));
            oSelect4.SelectByText("South Africa");
            driver.FindElement(By.Id("Physical_Postal_Code")).SendKeys("6166");
            Thread.Sleep(5000);
            IWebElement Element2 = driver.FindElement(By.XPath("//button[contains(text(),'Select')]"));
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("arguments[0].scrollIntoView();", Element2);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'Select')]")).Click();
            driver.FindElement(By.XPath("//input[@id='ms-opt-13']")).Click();
            driver.FindElement(By.XPath("//input[@id='ms-opt-2']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='Postal_Code']")).Click();
            driver.FindElement(By.XPath("//input[@id='First_Name']")).SendKeys("Verryl");
            driver.FindElement(By.XPath("//input[@id='Last_Name']")).SendKeys("Laxi");
            driver.FindElement(By.XPath("//input[@id='Cell_Contact_Number']")).SendKeys("06399865018");
            driver.FindElement(By.XPath("//button[@id='Grp_Contact_BTN']")).Click();
            Thread.Sleep(5000);
            IWebElement Element1 = driver.FindElement(By.XPath("//button[@id='Grp_Contact_BTN']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", Element1);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='Grp_Contact_BTN']")).Click();
            driver.FindElement(By.Id("SAVEBTN")).Click();
            Thread.Sleep(1000);
            IWebElement ele9 = driver.FindElement(By.XPath("//input[@id='Email_Id']"));
            string email = ele9.Text;
            Console.WriteLine("Entered Email ID" +email);
            Thread.Sleep(5000);
            IWebElement Element9 = driver.FindElement(By.XPath("//button[@id='NXTBTN']"));
            IJavaScriptExecutor js9 = (IJavaScriptExecutor)driver;
            js9.ExecuteScript("arguments[0].scrollIntoView();", Element9);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            Thread.Sleep(5000);
            SelectElement oSelect5 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Document_Type_Id']")));
            oSelect5.SelectByText("Other");
            driver.FindElement(By.XPath("//input[@id='Document_Name']")).SendKeys("STL");
            driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[4]/label[1]")).Click();
            Thread.Sleep(6000);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//button[@id='GRP_DOC_BTN']")).Click();
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='Bank_Name']")).SendKeys("ASSI");
            driver.FindElement(By.XPath("//input[@id='Account_Number']")).SendKeys("1021154552255");
            driver.FindElement(By.XPath("//input[@id='Account_Holder_Name']")).SendKeys("Laxi Raival");
            SelectElement oSelect6 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Payment_Method_Id']")));
            oSelect6.SelectByText("EFT");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='SBTN']")).Click();
            Thread.Sleep(1000);
            Assert.That("http://staging.mic.dev2stage.in/ServiceProvider/ListServiceProvider", Is.EqualTo("http://staging.mic.dev2stage.in/ServiceProvider/ListServiceProvider"));
            Console.WriteLine("Service Provider Added Successfully");
            WebElement driver6 = (WebElement)driver.FindElement(By.Id("DT_load"));
            string data = driver6.Text;
            Console.WriteLine(data);
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}