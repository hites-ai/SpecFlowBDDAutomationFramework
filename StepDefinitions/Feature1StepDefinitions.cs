using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {
        private IWebDriver driver;

       public Feature1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
         //   driver = new ChromeDriver();
         //   driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            
        }
      
        [Then(@"Search for the android Mobile")]
        public void ThenSearchForTheAndroidMobile()
        {
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys("Android Mobiles");
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Samsung mobile")]
        public void ThenSearchForTheSamsungMobile()
        {
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys("Samsung Mobiles");
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

    }
}