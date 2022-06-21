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


namespace MIC
{
    internal class Add_Group
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
        public void Add_A_Group()
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
            driver.FindElement(By.XPath("//label[contains(text(),'Groups')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Add Group')]")).Click();
            driver.FindElement(By.Id("Group_Name")).SendKeys("SSF Group Of Pvt. Limited");
            driver.FindElement(By.Id("Contact_Number_Work")).SendKeys("06355986523");
            driver.FindElement(By.Id("Email_Id")).SendKeys("absa.grf@sf.in");
            driver.FindElement(By.XPath("//input[@id='Registration_Date']")).Click();
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[2]")));
            oSelect1.SelectByText("2022");
            SelectElement oSelect2 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[1]")));
            oSelect2.SelectByText("Jan");
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[1]")).Click();
            driver.FindElement(By.Id("Postal_Address")).SendKeys("1381 Willow St");
            driver.FindElement(By.Id("Postal_City")).SendKeys("Humansdorp");
            SelectElement oSelect3 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Postal_Country_Id']")));
            oSelect3.SelectByText("American Samoa");
            driver.FindElement(By.Id("Postal_Code")).SendKeys("0968");
            driver.FindElement(By.Id("First_Name")).SendKeys("James");
            driver.FindElement(By.Id("Last_Name")).SendKeys("V. Jenkins");
            driver.FindElement(By.Id("Cell_Contact_Number")).SendKeys("06355986532");
            Thread.Sleep(5000);
            IWebElement Element3 = driver.FindElement(By.Id("Grp_Contact_BTN"));
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript("arguments[0].scrollIntoView();", Element3);
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Grp_Contact_BTN")).Click();
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            Thread.Sleep(5000);
            SelectElement oSelect4 = new SelectElement(driver.FindElement(By.Id("Document_Type_Id")));
            oSelect4.SelectByText("Other");
            driver.FindElement(By.Id("Document_Name")).SendKeys("IRC");
            driver.FindElement(By.Id("Document_Number")).SendKeys("986520551221");
            driver.FindElement(By.Id("Document_Number")).SendKeys("123658");
            IWebElement wb1 = driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[4]/label[1]"));
            wb1.Click();
            Thread.Sleep(6000);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='GRP_DOC_BTN']")).Click();
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Bank_Name")).SendKeys("ASSICX");
            driver.FindElement(By.Id("Account_Number")).SendKeys("101125698552");
            driver.FindElement(By.Id("Account_Holder_Name")).SendKeys("Sark Halpar");
            SelectElement oSelect5 = new SelectElement(driver.FindElement(By.Id("Payment_Method_Id")));
            oSelect5.SelectByText("EFT");
            driver.FindElement(By.Id("SBTN")).Click();
            Thread.Sleep(5000);
            Console.WriteLine("Group Added");   
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}