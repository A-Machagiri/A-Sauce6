using OpenQA.Selenium;

namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");
        // Add other locators for the product page after login for assertion purposes
    }
}