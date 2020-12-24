using DaviesGroupProject.Framework.Base;
using DaviesGroupProject.Pages;
using NUnit.Framework;

namespace DaviesGroupProject.Tests
{
    [TestFixture]
    public class LocationsTests : BaseTests
    {
        [Test(Description = "capture Stoke Office address from the Maps in Menu -> ‘About Us’ -> ‘Locations’.")]
        public void StokeOnMap()
        {
            HomePage homePage = new HomePage(driver);
            LocationsPage locationsPage = new LocationsPage(driver);
            homePage.DriverGoToHomeUrl();
            homePage.ClickLocations();
            locationsPage.ClickOnMap();
            locationsPage.AssertAddress();
            locationsPage.GetAddress();
        }
    }
}
