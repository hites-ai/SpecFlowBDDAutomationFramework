using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class ExamplesDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

       public ExamplesDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Then(@"Search with (.*)")]
        public void ThenSearchWithSpecflowByTestersTalk(string searchKey)
        {
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


    }
}