using TechTalk.SpecFlow;
using YourNamespace.PageObjects.Login;

namespace YourNamespace.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage;

        public LoginSteps()
        {
            WebUtilities webUtilities = new WebUtilities();
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I navigate to "(.*)"")]
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
            loginPage.EnterCredentials("incorrect_user", "wrong_password");
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            // Add assertion for redirection to product page
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Add assertion for error message
        }
    }
}