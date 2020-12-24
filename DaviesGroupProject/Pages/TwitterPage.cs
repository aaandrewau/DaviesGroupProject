using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using DaviesGroupProject.Framework.AbstractComponents;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class TwitterPage : AbstractPage
    {
        public TwitterPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebDriver driver;

        public IWebElement groupTittle => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div/div[1]/div/div[2]/div/div/div[1]/div/span[1]/span"));

        public TwitterPage AssertPage()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            WaitUntilPageIsLoaded();
            Assert.That(driver.Url.Contains("https://twitter.com/Davies_Group"));
            Assert.That(groupTittle.Text == "Davies Group");            
            return this;
        }

    }
}
