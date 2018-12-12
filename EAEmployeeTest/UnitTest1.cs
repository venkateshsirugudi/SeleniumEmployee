using System;
using EAAutoFramework.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1:BaseSuper
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl("https:\\www.mail.com");
            DriverContext.Driver.Manage().Window.Maximize();

            LoginPage page = new LoginPage();
            page.ClickLoginLink();
            CurrentPage= page.Login("venkateshsirugudi", "pinky7007");
            ((HomePage)CurrentPage).lnkSearch.Click();
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();

        }

        





    }
}
