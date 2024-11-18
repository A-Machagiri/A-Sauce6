namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        private readonly WebUtilities webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            this.webUtilities = webUtilities;
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

        // Add methods to interact with product page elements for assertion
        // ...
    }
}