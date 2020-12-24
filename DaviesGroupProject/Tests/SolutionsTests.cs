using DaviesGroupProject.Pages;
using DaviesGroupProject.Framework.Base;
using NUnit.Framework;
using DaviesGroupProject.DTO;

namespace DaviesGroupProject.Tests
{
    [TestFixture]
    public class SolutionTests : BaseTests
    {
        [Test(Description = "Validate ‘Fire investigation’ Case study page.")]
        public void FireInvestigationCaseStudy()
        {
            HomePage homePage = new HomePage(driver);
            SolutionsPage solutionsPage = new SolutionsPage(driver);
            FireInvestigationPage fireInvestigationPage = new FireInvestigationPage(driver);
            homePage.DriverGoToHomeUrl();
            homePage.ClickSolutions();
            solutionsPage.ClickViewAll();
            solutionsPage.Search("Fire investigation");
            fireInvestigationPage.AssertPage();
            fireInvestigationPage.GetResult();
        }
    }
}
