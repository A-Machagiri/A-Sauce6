using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Utilities.WebUtilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;

        public IWebDriver InitializeDriver(string browserType)
        {
            switch (browserType.ToLower())
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                case "edge":
                    _driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported.");
            }
            return _driver;
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public void SendKeys(By locator, string text)
        {
            FindElement(locator).SendKeys(text);
        }

        public void Quit()
        {
            _driver.Quit();
        }
    }
}