# Davies Group Project

https://davies-group.com/
Testing the social media buttons in home page.
Testing the solutions page for fire investigation case study.
Testing the locations page for Stoke-On-Trent office.

## Getting Started



### Prerequisites

```
1. clone the project
2. Install Microsoft Visual Studio 2019
3. Install the following NuGet Packages in VS (Menu -> Project -> Manage NuGet Packages)
	a. NUnit (3.12.0)
	b. NUnit3TestAdapter (3.16.1)
	c. selenium.support (3.141.0)
	d. selenium.webdriver (3.141.0)
	e. selenium.webdriver.chromedriver (87.0.4280.8800)
	f. dotnetseleniumextras.waithelpers (3.11.0)
```

## Running the tests

1. Open the solution in Visual Studio.
2. Open Test Explorer.
3. Click 'run all' (CTRL + r,v) to run all the test.
4. Captured results for the case study and address would be shown in addtional output for the result.

### Tests break down

```
HomeTests.cs
* TwitterIconOnHomePage()
	- Click on ‘Twitter’ Icon’s on the home page and Validate if it navigates to respective social media webpages.
* LinkedInIconOnHomePage()
	- Click on ‘linkedIn’ Icon’s on the home page and Validate if it navigates to respective social media webpages.
	- Due to robot check in Linkedin, not able to be redirected to Davies Group Linkedin Page. 
	- Steps linkedinPage.Login(users) & linkedinPage.AssertPage() for login and assert linkedin page are commented out due to the reason above.
	- Assert the linkined URL to validate if it navigates to linkined website.

SolutionsTests.cs
* FireInvestigationCaseStudy()
	- Click on ‘Solutions’ – Scroll down and click on ‘View All’ – look for ‘Fire investigation’ Case study and click on it – Validate if it’s navigated to right page.
	- Capture the Results section from ‘Fire Investigation’ case study.
	- Click the test result or 'CodeLens Test Status' and open addtional output for this result to review captured results section.

LocationsTests.cs
* StokeOnMap()
	- Click on Menu ->  ‘About Us’ -> ‘Locations’ and capture Stoke Office address from the Maps.
	- Click the test result or 'CodeLens Test Status' and open addtional output for this result to review captured address.
```

## Built With

* [Nunit] - The unit testing framework used
* [Selenium] - The web applications testing framework used
* [Selenium ChromeDriver] - The chrome WebDriver used
* [Windows 10]

