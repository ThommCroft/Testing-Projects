using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Web_Testing_Sauce_Demo.Pages
{
    public class InventoryPage
    {
        private IWebDriver _driver;

        private IWebElement _inventoryTitle => _driver.FindElement(By.ClassName("title"));
        private IWebElement _filterButton => _driver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _azFilter => _driver.FindElement(By.XPath("//option[@value='az']"));
        private IWebElement _zaFilter => _driver.FindElement(By.XPath("//option[@value='za']"));
        private IWebElement _lowHighFilter => _driver.FindElement(By.XPath("//option[@value='lohi']"));
        private IWebElement _highLowFilter => _driver.FindElement(By.XPath("//option[@value='hilo']"));

        private IList<IWebElement> _products => _driver.FindElements(By.ClassName("inventory_item"));

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void WaitForPageToDisplay()
        {
            var waitTime = new WebDriverWait(_driver, TimeSpan.FromSeconds(12)).Until(_driver => _driver.FindElement(By.ClassName("title")));
        }

        public string GetInventoryTitle() => _inventoryTitle.Text;

        public void AddProductToCart(string productName)
        {
            // loop through the Product Elements List to find the product past by the parameter

            // Find that products AddToCart Button and Click it.
        }

        public List<string> GetAToZProductNames()
        {
            List<string> originalProductOrderNames = new List<string>();

            foreach (var product in _products)
            {
                originalProductOrderNames.Add(product.FindElement(By.ClassName("inventory_item_name")).Text);
            }

            originalProductOrderNames.Order();

            return originalProductOrderNames;
        }

        public List<string> GetZToAProductNames()
        {
            List<string> originalProductOrderNames = new List<string>();

            foreach (var product in _products)
            {
                originalProductOrderNames.Add(product.FindElement(By.ClassName("inventory_item_name")).Text);
            }

            originalProductOrderNames.OrderDescending();

            return originalProductOrderNames;
        }

        public List<string> FilterProductsFromAToZ()
        {
            _filterButton.Click();

            // Possible Wait
            Thread.Sleep(1000);

            _azFilter.Click();

            List<string> actualProductNames = new List<string>();
            IList<IWebElement> orderedProducts = _driver.FindElements(By.ClassName("inventory_item"));

            // Compare the Original List of Products is different to the new Order.
            foreach (var product in orderedProducts)
            {
                actualProductNames.Add(product.FindElement(By.ClassName("inventory_item_name")).Text);
            }

            return actualProductNames;
        }

        public List<string> FilterProductsFromZToA()
        {
            _filterButton.Click();

            // Possible Wait
            Thread.Sleep(1000);

            _zaFilter.Click();

            List<string> actualProductNames = new List<string>();
            IList<IWebElement> orderedProducts = _driver.FindElements(By.ClassName("inventory_item"));

            // Compare the Original List of Products is different to the new Order.
            foreach (var product in orderedProducts)
            {
                actualProductNames.Add(product.FindElement(By.ClassName("inventory_item_name")).Text);
            }

            return actualProductNames;
        }
    }
}
