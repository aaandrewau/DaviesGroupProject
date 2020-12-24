using DaviesGroupProject.Framework.AbstractComponents;
using DaviesGroupProject.Framework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver;

        public IWebElement homeLogo => driver.FindElement(By.ClassName("custom-logo-link"));
        public IWebElement twitterIcon => driver.FindElement(By.XPath("/html/body/div[1]/footer/div/div[1]/div[2]/ul/li[1]"));
        public IWebElement linkedinIcon => driver.FindElement(By.XPath("/html/body/div[1]/footer/div/div[1]/div[2]/ul/li[2]"));
        public IWebElement linkedinLink => driver.FindElement(By.XPath("/html/body/div[1]/footer/div/div[1]/div[2]/ul/li[2]/a"));
        public IWebElement solutionsbtn => driver.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[1]/div/div[1]/nav/div[1]/ul/li[1]/a"));
        public IWebElement discoverMorebtn => driver.FindElement(By.XPath("/html/body/div[1]/div/section[6]/div/div/div[2]/a/div/span"));
        public IWebElement aboutbtn => driver.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[1]/div/div[1]/nav/div[1]/ul/li[2]/a"));
        public IWebElement locationsbtn => driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[2]/div/ul/li[4]/a"));

        public HomePage DriverGoToHomeUrl()
        {
            driver.Navigate().GoToUrl("https://davies-group.com/");            
            return this;
        }
        public HomePage AssertHomePage()
        {
            Assert.That(homeLogo.GetAttribute("tittle") == "Davies");
            return this;
        }
        public HomePage ScrollToFooter()
        {
            UtilityClass UtilityClass = new UtilityClass(driver);
            UtilityClass.ScrollIntoViewByHeight(discoverMorebtn.Location.Y, driver);
            return this;
        }

        public HomePage ClickTwitterIcon()
        {
            Assert.That(twitterIcon.Displayed);
            twitterIcon.Click();
            return this;
        }

        public HomePage ClickLinkedinIcon()
        {
            Assert.That(linkedinLink.GetAttribute("href") == "https://www.linkedin.com/company/daviesgroup/");
            Assert.That(linkedinIcon.Displayed);
            linkedinIcon.Click();
            return this;
        }
        public HomePage ClickSolutions()
        {
            solutionsbtn.Click();
            return this;
        }
        public HomePage ClickLocations()
        {
            WaitUntilPageIsLoaded();
            Actions actions = new Actions(driver);
            actions.MoveToElement(aboutbtn, 0, 0).Perform();
            Thread.Sleep(1000);
            locationsbtn.Click();
            return this;
        }
    }
}
