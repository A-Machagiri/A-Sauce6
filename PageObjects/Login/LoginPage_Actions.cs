using Utilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            this.webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(UsernameField, username);
            webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLogin()
        {
            webUtilities.Click(LoginButton);
        }

        public bool IsErrorMessageDisplayed()
        {
            return webUtilities.FindElement(ErrorMessage).Displayed;
        }

        public bool IsProductPageDisplayed()
        {
            return webUtilities.FindElement(ProductPageElement).Displayed;
        }
    }
}