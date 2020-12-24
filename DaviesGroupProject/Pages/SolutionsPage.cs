using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using DaviesGroupProject.Framework.AbstractComponents;
using DaviesGroupProject.Framework;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class SolutionsPage : AbstractPage
    {
        public SolutionsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver;

        public IWebElement viewAllBtn => driver.FindElement(By.CssSelector("span[class='cta-button__icon view-all__icon cta-button__arrow view-all__arrow']"));
        public IWebElement searchInput => driver.FindElement(By.ClassName("select2-search__field"));
        public IWebElement searchField => driver.FindElement(By.Id("select2--container"));
        public IWebElement header => driver.FindElement(By.Id("header-wrap"));


        public SolutionsPage ClickViewAll()
        {
            WaitUntilPageIsLoaded();
            UtilityClass UtilityClass = new UtilityClass(driver);
            UtilityClass.ScrollIntoViewByHeight(viewAllBtn.Location.Y - header.Size.Height, driver);
            Thread.Sleep(2000);
            viewAllBtn.Click();
            return this;
        }
        public SolutionsPage Search(string text)
        {
            Assert.That(searchField.Text.Contains("Search for keywords"));
            searchField.Click();
            searchInput.SendKeys(text);
            Actions actions = new Actions(driver);
            actions.MoveToElement(searchInput).MoveByOffset(0, searchInput.Size.Height).Click().Build().Perform();
            return this;
        }
    }
}
