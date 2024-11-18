using Utilities.WebUtilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private readonly WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            this.webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            var usernameField = webUtilities.FindElement(UsernameField);
            var passwordField = webUtilities.FindElement(PasswordField);
            webUtilities.SendKeys(usernameField, username);
            webUtilities.SendKeys(passwordField, password);
        }

        public void ClickLoginButton()
        {
            var loginButton = webUtilities.FindElement(LoginButton);
            webUtilities.Click(loginButton);
        }

        // Add methods to interact with the product page for assertion
    }
}