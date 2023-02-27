using OpenQA.Selenium;

namespace Selenium_Web_Testing_Sauce_Demo.Pages
{
    public class InventoryPage
    {
        private IWebDriver _driver;

        private IWebElement _inventoryTitle => _driver.FindElement(By.ClassName("title"));

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetInventoryTitle() => _inventoryTitle.Text;
    }
}
