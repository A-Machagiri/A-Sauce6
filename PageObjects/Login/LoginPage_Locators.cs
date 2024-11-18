using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public static By UsernameField = By.Id("username");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login");
        public static By ErrorMessage = By.Id("error");
        public static By ProductPageElement = By.Id("productPage");
    }
}