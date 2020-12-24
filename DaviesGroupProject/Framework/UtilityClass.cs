using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace DaviesGroupProject.Framework
{
    public class UtilityClass
    {
        public static IWebDriver _driver;
        protected readonly WebDriverWait WebDriverWait;

        public UtilityClass(IWebDriver driver)
        {
            _driver = driver;
        }
        public void ScrollIntoViewByHeight(int h, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;            
            js.ExecuteScript("window.scrollBy(0," + h.ToString() + ")");
        }

        public void ScrollElementIntoView(By elementLocator, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: \"smooth\", block: \"start\"});", driver.FindElement(elementLocator));
        }

        protected IWebElement WaitForElementToExistByCssSelector(string eleLocator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement e = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(eleLocator)));
            return e;
        }
    }
}
