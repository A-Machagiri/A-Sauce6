using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        private WebUtilities webUtilities;

        public Hooks(IObjectContainer container)
        {
            objectContainer = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities = new WebUtilities();
            driver = webUtilities.InitializeDriver("chrome"); // or "firefox", "edge"
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            objectContainer.RegisterInstanceAs<WebUtilities>(webUtilities);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}