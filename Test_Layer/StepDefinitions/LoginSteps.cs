using NUnit.Framework;
using PageObjects.Login;
using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage;
        private readonly WebUtilities webUtilities;

        public LoginSteps(WebUtilities utilities)
        {
            webUtilities = utilities;
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
            loginPage.EnterCredentials("locked_out_user", "secret_sauce");
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            // Add assertion to check redirection to the product page
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Add assertion to check for error message
        }
    }
}