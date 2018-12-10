using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https:\\google.com");
        }



    }
}
