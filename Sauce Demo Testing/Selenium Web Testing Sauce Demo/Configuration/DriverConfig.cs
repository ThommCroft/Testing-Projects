using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Web_Testing_Sauce_Demo.Configuration
{
    public class DriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public DriverConfig(int pageLoadInSeconds, int implicitWaitInSeconds, bool isHeadless)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSeconds, implicitWaitInSeconds, isHeadless);
        }

        private void DriverSetUp(int pageLoadInSeconds, int implicitWaitInSeconds, bool isHeadless)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSeconds); // The time the Driver will wait for the page to load.
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSeconds); // The time the driver will wait for the elements.

            if (isHeadless)
            {
                SetHeadless();
            }
        }

        private void SetHeadless()
        {
            if (Driver is ChromeDriver)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("headless");

                Driver.Dispose();
                Driver = new ChromeDriver(options);
            }
            else
            {
                throw new ArgumentException("Browser is not supported by Framework");
            }
        }
    }
}
