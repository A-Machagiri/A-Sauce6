using TechTalk.SpecFlow;
using YourNamespace.Utilities.WebUtilities;

namespace YourNamespace.Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly WebUtilities webUtilities;

        public Hooks()
        {
            webUtilities = new WebUtilities();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities.InitializeDriver("chrome"); // You can make this dynamic based on config
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}