using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = WebUtilities.InitializeDriver();
            _scenarioContext["WebDriver"] = _driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}