using OpenQA.Selenium;

namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        // Define locators here
        public By UsernameField => By.Id("user-name");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.ClassName("btn_action");
        // Add locators for product page after login for assertion
        // ...
    }
}