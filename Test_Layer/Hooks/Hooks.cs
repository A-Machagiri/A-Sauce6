using TechTalk.SpecFlow;
using YourNamespace.Utilities.WebUtilities;

namespace YourNamespace.Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private WebUtilities webUtilities;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities = new WebUtilities();
            webUtilities.InitializeDriver("chrome"); // Or read from config
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}