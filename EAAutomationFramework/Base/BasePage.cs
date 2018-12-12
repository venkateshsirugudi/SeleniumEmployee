
using OpenQA.Selenium.Support.PageObjects;


namespace EAAutoFramework.Base
{
    public abstract class BasePage: BaseSuper
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
