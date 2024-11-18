using OpenQA.Selenium;

namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField = By.Id("username");
        public By PasswordField = By.Id("password");
        public By LoginButton = By.Id("login");
        public By ErrorMessage = By.Id("error");
    }
}