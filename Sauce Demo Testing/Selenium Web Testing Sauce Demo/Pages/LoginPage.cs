using OpenQA.Selenium;
using Selenium_Web_Testing_Sauce_Demo.Configuration;

namespace Selenium_Web_Testing_Sauce_Demo.Pages
{
    public class LoginPage
    {
        private string loginURL = ConfigReader.baseUrl;

        private IWebDriver _driver;

        private IWebElement _usernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessageBox => _driver.FindElement(By.ClassName("error-message-container error"));

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage() => _driver.Navigate().GoToUrl(loginURL);
        public void EnterUsername(string username) => _usernameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);
        public void ClickLoginButton() => _loginButton.Click();
        public string GetErrorMessageText() => _errorMessageBox.Text;

        public void LoginUser(string username, string password)
        {
            _usernameField.SendKeys(username);
            _passwordField.SendKeys(password);
            _loginButton.Click();
        }
    }
}
