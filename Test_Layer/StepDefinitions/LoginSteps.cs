using TechTalk.SpecFlow;
using YourNamespace.PageObjects.Login;
using YourNamespace.Utilities.WebUtilities;
using NUnit.Framework;

namespace YourNamespace.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage;
        private readonly WebUtilities webUtilities;

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

        [When("I enter valid credentials from \"(.*)\"")]
        public void WhenIEnterValidCredentialsFrom(string csvFilePath)
        {
            // Assuming CSV file is read and parsed here to get username and password
            string username = "standard_user"; // Example username
            string password = "secret_sauce"; // Example password
            loginPage.EnterCredentials(username, password);
        }

        [When("I enter invalid credentials from \"(.*)\"")]
        public void WhenIEnterInvalidCredentialsFrom(string csvFilePath)
        {
            // Assuming CSV file is read and parsed here to get username and password
            string username = "incorrect_user"; // Example invalid username
            string password = "secret_sauce"; // Example password
            loginPage.EnterCredentials(username, password);
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            // Example assertion for product page
            Assert.IsTrue(webUtilities.FindElement(By.Id("product_page_id")).Displayed); // Example locator
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(webUtilities.FindElement(loginPage.ErrorMessage).Displayed);
        }
    }
}