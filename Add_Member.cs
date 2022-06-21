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
    internal class Add_Member
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
        public void Add_A_Member()
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
            driver.FindElement(By.XPath("//label[contains(text(),'Membership')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Add Member')]")).Click();
            IWebElement TitleDrop_Down = driver.FindElement(By.XPath("//select[@id='Title_Id']"));
            SelectElement Select_Title = new SelectElement(TitleDrop_Down);
            Select_Title.SelectByText("Mr");
            driver.FindElement(By.XPath("//input[@id='First_Name']")).SendKeys("Bearry");
            driver.FindElement(By.XPath("//input[@id='Last_Name']")).SendKeys("Newbarry");
            driver.FindElement(By.XPath("//input[@id='Date_of_Birth']")).Click();
            SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[2]")));
            oSelect.SelectByText("1998");
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[1]")));
            oSelect1.SelectByText("Jun");
            driver.FindElement(By.XPath("//tbody/tr[1]/td[4]/a[1]")).Click();
            IWebElement wb = driver.FindElement(By.XPath("//input[@id='wizardpicture']"));
            wb.SendKeys("C:\\Users\\mruty\\Downloads\\6da30596-d6b1-4474-bbde-c4cf4b411460 (1).jpg");
            SelectElement oSelect2 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Marital_Status_Id']")));
            oSelect2.SelectByText("Married");
            driver.FindElement(By.XPath("//input[@id='Occupation']")).SendKeys("Doctor");
            SelectElement oSelect3 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Blood_Group_Id']")));
            oSelect3.SelectByText("A+");
            SelectElement oSelect14 = new SelectElement(driver.FindElement(By.Id("Gender_Id")));
            oSelect14.SelectByText("Male");
            SelectElement oSelect4 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Ethnicity_Id']")));
            oSelect4.SelectByText("Black");
            driver.FindElement(By.XPath("//input[@id='Address']")).SendKeys("2025 Robertson Ave");
            driver.FindElement(By.XPath("//input[@id='City']")).SendKeys("Mokopane");
            SelectElement oSelect5 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Country_Id']")));
            oSelect5.SelectByText("South Africa");
            driver.FindElement(By.XPath("//input[@id='Postal_Code']")).SendKeys("9062");
            driver.FindElement(By.XPath("//input[@id='Contact_Number_Cell']")).SendKeys("06852248062");
            driver.FindElement(By.XPath("//input[@id='Email_Id']")).SendKeys("berrynewberry@sm.in");
            driver.FindElement(By.XPath("//input[@id='Registration_Date']")).Click();
            SelectElement oSelect6 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[2]")));
            oSelect6.SelectByText("2022");
            SelectElement oSelect7 = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[1]")));
            oSelect7.SelectByText("Jan");
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[1]")).Click();
            driver.FindElement(By.XPath("//input[@id='First_Name_EM']")).SendKeys("Thomous");
            driver.FindElement(By.XPath("//input[@id='Last_Name_EM']")).SendKeys("Newbarry");
            SelectElement oSelect8 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Relationship_Id']")));
            oSelect8.SelectByText("Brother");
            driver.FindElement(By.XPath("//input[@id='Contact_Number']")).SendKeys("06855420698");
            IWebElement Element3 = driver.FindElement(By.Id("Emer_Contact_BTN"));
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript("arguments[0].scrollIntoView();", Element3);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Emer_Contact_BTN")).Click();
            Thread.Sleep(5000);
            IWebElement Element = driver.FindElement(By.Id("Current_Plan_Id"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
            SelectElement oSelect9 = new SelectElement(driver.FindElement(By.Id("Current_Plan_Id")));
            oSelect9.SelectByText("Gold Plan");
            SelectElement oSelect10 = new SelectElement(driver.FindElement(By.Id("Current_Member_Cat_Id")));
            oSelect10.SelectByText("Single member");

            IWebElement Element1 = driver.FindElement(By.XPath("//button[@id='NXTBTN']"));
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("arguments[0].scrollIntoView();", Element1);

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='NXTBTN']")).Click();
            Thread.Sleep(5000);
            Console.WriteLine("Heyy");
            driver.FindElement(By.Id("NXTBTN")).Click();
            Thread.Sleep(5000);
            SelectElement oSelect13 = new SelectElement(driver.FindElement(By.Id("Beneficiary_Id")));
            oSelect13.SelectByText("Bearry Newbarry (PM)");
            driver.FindElement(By.XPath("//button[contains(text(),'Select')]")).Click();
            driver.FindElement(By.XPath("//input[@id='ms-opt-1']")).Click();
            driver.FindElement(By.Id("MD_HS_BTN")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            Thread.Sleep(5000);
            Console.WriteLine("Medical Cond Added");
            SelectElement oSelect15 = new SelectElement(driver.FindElement(By.Id("Beneficiary_Id")));
            oSelect15.SelectByText("Bearry Newbarry (PM)");
            SelectElement oSelect16 = new SelectElement(driver.FindElement(By.Id("Document_Type_Id")));
            oSelect16.SelectByText("ID Proof");
            driver.FindElement(By.Id("Document_Number")).SendKeys("123658");
            IWebElement wb1 = driver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[5]/label[1]"));
            wb1.Click();
            Thread.Sleep(6000);
            //new WebDriverWait.Until(ExpectedConditions.elementToBeClickable(By.cssSelector(button.nsg - button))).click();
            Thread.Sleep(6000);
            driver.FindElement(By.Id("MBR_DOC_BTN")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("NXTBTN")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='Bank_Name']")).SendKeys("ASSIC");
            driver.FindElement(By.XPath("//input[@id='Account_Number']")).SendKeys("10112598652");
            driver.FindElement(By.XPath("//input[@id='Account_Holder_Name']")).SendKeys("Berry NewBerry");
            SelectElement oSelect17 = new SelectElement(driver.FindElement(By.XPath("//select[@id='Payment_Method_Id']")));
            oSelect17.SelectByText("EFT");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='SBTN']")).Click();
            Thread.Sleep(2000);
            Console.WriteLine("Member Added Successfully");
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}