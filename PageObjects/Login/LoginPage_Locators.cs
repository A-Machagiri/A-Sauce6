using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField => By.Id("user-name");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.ClassName("btn_action");
        // Add other locators for the product page after login for assertion
    }
}