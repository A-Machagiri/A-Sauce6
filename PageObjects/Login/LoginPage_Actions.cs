namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            this.webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(usernameField, username);
            webUtilities.SendKeys(passwordField, password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(loginButton);
        }

        // Add other methods to interact with the product page after login
    }
}