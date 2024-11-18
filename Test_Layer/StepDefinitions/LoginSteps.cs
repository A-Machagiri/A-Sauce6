using TechTalk.SpecFlow;
using YourNamespace.PageObjects.Login;
using YourNamespace.Utilities.WebUtilities;
using NUnit.Framework;

namespace YourNamespace.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly WebUtilities _webUtilities;

        public LoginSteps()
        {
            _webUtilities = new WebUtilities();
            _loginPage = new LoginPage(_webUtilities);
        }

        [Given("I navigate to the \"https://www.saucedemo.com/\"")]
        public void GivenINavigateToTheLoginPage()
        {
            _webUtilities.NavigateToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            _loginPage.EnterCredentials("invalid_user", "secret_sauce");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            Assert.IsTrue(_webUtilities.FindElement(_loginPage.ProductPageLocator).Displayed);
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_webUtilities.FindElement(_loginPage.ErrorMessage).Displayed);
        }
    }
}