using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest
{
    class LoginPage:BasePage
    {
        [FindsBy(How=How.Id,Using = "login-button")]
        public IWebElement lnkLogin { get; set; }
        [FindsBy(How =How.Id,Using = "login-email")]
        public IWebElement txtUserName { get; set; }
        [FindsBy(How=How.Id,Using =("login-password"))]
        public IWebElement txtPassword { get; set; }
        [FindsBy(How=How.XPath,Using ="//button[@type='submit' and @class='btn btn-block login-submit']")]
        public IWebElement btnLogin { get; set; }

        public HomePage Login(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();
            System.Threading.Thread.Sleep(5000);
            return new HomePage();
        }

        public void ClickLoginLink()
        {
            lnkLogin.Click();
        }

    }
}
