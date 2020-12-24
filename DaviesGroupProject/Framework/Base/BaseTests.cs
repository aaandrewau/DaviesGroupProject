using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DaviesGroupProject.Framework.Base

{
    [TestFixture]
    public class BaseTests
    {
        protected IWebDriver driver;

        public BaseTests()
        {

        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}