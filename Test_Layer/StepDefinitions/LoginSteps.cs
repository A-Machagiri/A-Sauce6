using TechTalk.SpecFlow;
using YourNamespace.PageObjects.Login;
using YourNamespace.Utilities.WebUtilities;

namespace YourNamespace.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private WebUtilities webUtilities;

        public LoginSteps(WebUtilities webUtilities)
        {
            this.webUtilities = webUtilities;
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I navigate to \"(.*)\"")]
        public void GivenINavigateTo(string url)
        {
            webUtilities.NavigateToUrl(url);
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPage.EnterCredentials("invalid_user", "invalid_password");
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assert that the URL or page title matches the expected product page
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(loginPage.IsErrorMessageVisible());
        }
    }
}