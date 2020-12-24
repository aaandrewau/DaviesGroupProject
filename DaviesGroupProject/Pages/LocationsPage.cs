using DaviesGroupProject.Framework.AbstractComponents;
using DaviesGroupProject.Framework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class LocationsPage : AbstractPage
    {
        public LocationsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebDriver driver;
        UtilityClass UtilityClass;

        public IWebElement mapStokeLocation => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/section/div/div/div/div[13]"));
        public IWebElement stokeAddress => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/section/ul/li[13]/p"));
        public IWebElement stokeTittle => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/section/ul/li[13]/p"));
        public IWebElement map => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/section/h2"));

        public LocationsPage ClickOnMap()
        {
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(mapStokeLocation).Click().Build().Perform();
            //mapStokeLocation.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", mapStokeLocation);
            return this;
        }
        public LocationsPage AssertAddress()
        {
            WaitForElementToExistByXPath("/html/body/div[1]/div/section[2]/div/div[1]/section/ul/li[13]/p");
            Thread.Sleep(2000);
            Assert.That(stokeAddress.Displayed);
            return this;
        }

        public LocationsPage GetAddress()
        {
            TestContext.Out.WriteLine(stokeAddress.Text);
            return this;
        }
    }
}
