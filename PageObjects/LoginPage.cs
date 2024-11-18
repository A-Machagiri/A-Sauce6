using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebUtilities webUtilities;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.webUtilities = new WebUtilities(driver);
        }

        public void NavigateToLogin(string url)
        {
            webUtilities.NavigateToUrl(url);
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.EnterText("username", username);
            webUtilities.EnterText("password", password);
        }

        public void ClickLoginButton()
        {
            webUtilities.ClickElement("loginButton");
        }
    }
}