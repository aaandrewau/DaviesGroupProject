using DaviesGroupProject.Pages;
using DaviesGroupProject.Framework.Base;
using NUnit.Framework;
using DaviesGroupProject.DTO;
using System.Threading;

namespace DaviesGroupProject.Tests
{
    [TestFixture]
    public class HomeTests : BaseTests
    {
        [Test(Description = "Click on ‘Twitter’ Icon’s on the home page and Validate if it navigates to respective social media webpages.")]
        public void TwitterIconOnHomePage()
        {
            HomePage homePage = new HomePage(driver);
            TwitterPage twitterPage = new TwitterPage(driver);
            homePage.DriverGoToHomeUrl();
            homePage.ScrollToFooter();
            homePage.ClickTwitterIcon();
            twitterPage.AssertPage();
        }

        [Test(Description = "Click on ‘linkedIn’ Icon’s on the home page and Validate if it navigates to respective social media webpages.")]
        public void LinkedInIconOnHomePage()
        {
            HomePage homePage = new HomePage(driver);
            LinkedinPage linkedinPage = new LinkedinPage(driver);
            Users users = new Users().LinkedinUser();

            homePage.DriverGoToHomeUrl();
            homePage.ScrollToFooter();
            homePage.ClickLinkedinIcon();
            linkedinPage.AssertUrl();
            //Not able to login via automation due to robot check in Linkedin
            //linkedinPage.Login(users);
            //linkedinPage.AssertPage();
        }
    }
}
