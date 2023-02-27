using OpenQA.Selenium;
using Selenium_Web_Testing_Sauce_Demo.Configuration;
using Selenium_Web_Testing_Sauce_Demo.Pages;

namespace Selenium_Web_Testing_Sauce_Demo
{
    public class WebManager<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public LoginPage LoginPage { get; set; }
        public InventoryPage InventoryPage { get; set; }

        public WebManager(int pageLoadTimeInSeconds = 5, int implicitWaitTimeInSeconds = 5, bool isHeadless = false)
        {
            Driver = new DriverConfig<T>(pageLoadTimeInSeconds, implicitWaitTimeInSeconds, isHeadless).Driver;

            LoginPage = new LoginPage(Driver);
            InventoryPage = new InventoryPage(Driver);
        }

        public void CloseWebBrowser()
        {
            Driver.Quit();
        }
    }
}
