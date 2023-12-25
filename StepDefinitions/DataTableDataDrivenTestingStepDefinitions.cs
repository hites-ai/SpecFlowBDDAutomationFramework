using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class DataTableDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

       public DataTableDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in Google")]
        public void ThenEnterSearchKeywordInGoogle(Table table)
        {
           var searchCriteria =  table.CreateSet<SearchKeyTestData>();

            foreach(var keyword in searchCriteria)
            {
                driver.FindElement(By.XPath("//textarea[@type='search']")).Clear();
                driver.FindElement(By.XPath("//textarea[@type='search']")).SendKeys(keyword.searchKey);
                driver.FindElement(By.XPath("//textarea[@type='search']")).SendKeys(Keys.Enter);
                Thread.Sleep(5000);
            }

        }



    }

    public class SearchKeyTestData
    {
        public string searchKey { get; set; }
    }



}