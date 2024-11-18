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
            webUtilities.SendKeys(UsernameField, username);
            webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(LoginButton);
        }
    }
}