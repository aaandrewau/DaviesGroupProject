using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaviesGroupProject.Framework.AbstractComponents
{
    public abstract class AbstractUI
    {
        protected IWebDriver Driver { get; set; }
        protected readonly WebDriverWait WebDriverWait;
        
        public AbstractUI(IWebDriver driver)
        {
            TimeSpan pageLoadTimeout = TimeSpan.FromSeconds(Convert.ToInt32(30));
            TimeSpan pollingInterval = TimeSpan.FromSeconds(Convert.ToInt32(30));
            Driver = driver;
            WebDriverWait = new WebDriverWait(driver, pageLoadTimeout)
            {
                PollingInterval = pollingInterval,
                Message = $"Webdriver timed out after {pageLoadTimeout.Seconds} seconds."
            };
            WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
        }
        protected IWebElement WaitForElementTextToExist(IWebElement element, string Text)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(element, Text));
            return element;
        }
        protected IWebElement WaitForElementToBeClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            return element;
        }
        protected IWebElement WaitForElementToExistByXPath(string eleLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            IWebElement e = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(eleLocator)));
            return e;
        }
        protected void WaitUntilPageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(driver1 => ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
