using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

       public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the Google URL")]
        public void GivenEnterTheURL()
        {
            driver.Url = "https://www.google.com/";
            Thread.Sleep(4000);
        }

        [When(@"Search for the Dbiz Solution")]
        public void WhenSearchForTheDbizSolution()
        {
            searchPage = new SearchPage(driver);

            resultPage = searchPage.searchText("Dbiz Solution");
            Thread.Sleep(4000);
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            channelPage = resultPage.clickOnChannel();
            Thread.Sleep(4000);
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            Assert.AreEqual("Welcome to Dbiz: Your Partner in Business and IT Excellence", channelPage.getTitle());
        }


    }
}