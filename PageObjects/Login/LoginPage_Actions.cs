namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private readonly WebUtilities.WebUtilities _webUtilities;

        public LoginPage(WebUtilities.WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(UsernameField, username);
            _webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginButton);
        }

        // Add methods to interact with product page elements for assertion
    }
}