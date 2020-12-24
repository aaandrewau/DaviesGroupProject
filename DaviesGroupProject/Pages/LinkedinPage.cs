using DaviesGroupProject.DTO;
using DaviesGroupProject.Framework.AbstractComponents;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;

namespace DaviesGroupProject.Pages
{
    public class LinkedinPage : AbstractPage
    {
        public LinkedinPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebDriver driver;

        public IWebElement signInBtn => driver.FindElement(By.XPath("/html/body/main/div/div/form[2]/section/p/a"));
        public IWebElement emailInput => driver.FindElement(By.Id("login-email"));
        public IWebElement passwordInput => driver.FindElement(By.Id("login-password"));
        public IWebElement loginBtn => driver.FindElement(By.Id("login-submit"));
        public IWebElement linkedinTitle => driver.FindElement(By.XPath("/html/body/div[9]/header/div[2]/h1/a/svg/title"));

        public IWebElement groupPageTitle => driver.FindElement(By.XPath("/html/body/div[9]/div[3]/div/div[3]/div[1]/section/div/div/div[2]/div[1]/div[1]/div[2]/div/h1/span"));
        public IWebElement securityCheck => driver.FindElement(By.XPath("/html/body/div/main/h1"));

        public LinkedinPage AssertUrl()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Assert.That(driver.Url.Contains("linkedin"));
            return this;
        }

        public LinkedinPage Login(Users users)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            WaitUntilPageIsLoaded();
            try
            {
                signInBtn.Click();
                emailInput.SendKeys(users.Email);
                passwordInput.SendKeys(users.Password);
                loginBtn.Click();
            }
            catch
            {
                if (securityCheck.Text.Contains("Let's do a quick security check"))
                {
                    Assert.Fail("Not able to login via automation due to robot check in Linkedin");
                }
            }
            return this;
        }
        public LinkedinPage AssertPage()
        {
            Assert.That(linkedinTitle.Text == "LinkedIn");
            Assert.That(groupPageTitle.Text == "Davies Group");
            return this;
        }
    }
}
