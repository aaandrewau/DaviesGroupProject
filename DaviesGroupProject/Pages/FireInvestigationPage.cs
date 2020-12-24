using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using DaviesGroupProject.Framework.AbstractComponents;
using DaviesGroupProject.Framework;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class FireInvestigationPage : AbstractPage
    {
        public FireInvestigationPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebDriver driver;
        UtilityClass UtilityClass;
        public IWebElement header => driver.FindElement(By.CssSelector("div[class='header__wrapper']"));
        public IWebElement tittle => driver.FindElement(By.CssSelector("h1[class='case-hero__title main-title text-semibold centered-case-title']"));
        public IWebElement intro1 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div/ul/li[1]/h3/p"));
        public IWebElement intro2 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div/ul/li[2]/h3/p"));
        public IWebElement intro3 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div/ul/li[3]/h3/p"));
        public IWebElement tittle1 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/div/div/h2[1]"));
        public IWebElement tittle1Content => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/div/div/p[1]"));
        public IWebElement tittle2 => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/div/div/h2[2]"));
        public IWebElement tittle2Content => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div[1]/div/div/p[2]"));

        public FireInvestigationPage AssertPage()
        {
            WaitUntilPageIsLoaded();
            Assert.That(driver.Url.Equals("https://davies-group.com/case-study/fire-investigation/"));
            Assert.That(header.Displayed);
            Assert.That(tittle.Text.Contains("Fire investigation"));
            Assert.That(intro1.Text.Contains("Luxury vehicle caught by fire"));
            Assert.That(intro2.Text.Contains("We investigated why"));
            Assert.That(intro3.Text.Contains("Dealership accepted fault & we recovered £46.353 for our client"));
            Assert.That(tittle1.Text.Contains("How we helped"));
            Assert.That(tittle1Content.Text.Contains("After a luxury 4×4 vehicle valued at £46,450 caught fire shortly after being collected from the franchised dealership, a top UK insurer asked us to investigate the cause. We sent a forensic fire investigator who identified that the fire had been caused by a small rubber seal that had been misaligned inside the engine."));
            Assert.That(tittle2.Text.Contains("Results"));
            Assert.That(tittle2Content.Text.Contains("The dealership accepted fault and with an outlay to us of £1,495 made a recovery of £46,353."));
            return this;
        }
        public FireInvestigationPage GetResult()
        {
            TestContext.Out.WriteLine(tittle2Content.Text);
            return this;
        }
    }
}
