using OpenQA.Selenium;


namespace DaviesGroupProject.Framework.AbstractComponents
{
    public abstract class AbstractPage : AbstractUI
    {
        protected AbstractPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
