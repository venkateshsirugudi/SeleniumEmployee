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
    class HomePage:BasePage
    {
    

        [FindsBy(How=How.XPath, Using ="//span[@class='userinfo-name']")]
        public IWebElement lblUsername { get; set; }

        [FindsBy(How=How.XPath,Using = "//span[text()='Search']")]
        public IWebElement lnkSearch { get; set; }



    }
}
