using OpenQA.Selenium.Chrome;

namespace Selenium_Web_Testing_Sauce_Demo.Tests
{
    public class FrameWorkTesting
    {
        // Git Commit Message:
        //  - Updated Typora and Created headers for Web UI Testing Projects and Sauce Demo.
        //  - Created the WebManager Class, ConfigReader, DriverConfig, the LoginPage Class and started the InventoryPage Class.
        //  - Create a Test to check the Framework is working correctly.

        private readonly WebManager<ChromeDriver> _webManager = new WebManager<ChromeDriver>();

        private readonly string standardUser = "standard_user";
        private readonly string lockedOutUser = "locked_out_user";
        private readonly string problemUser = "problem_user";
        private readonly string performanceUser = "performance_glitch_user";
        private readonly string password = "secret_sauce";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _webManager.LoginPage.NavigateToLoginPage();
            // Wait for Login Page to load
            Thread.Sleep(2000);
        }

        [Test]
        public void GivenAValidLogin_LoginPage_NavigateToInventoryPage()
        {
            _webManager.LoginPage.LoginUser(standardUser, password);

            // Wait for Inventory Page to load
            Thread.Sleep(2000);

            Assert.That(_webManager.InventoryPage.GetInventoryTitle(), Is.EqualTo("PRODUCTS")); // Title Class seems to Capitalise all letters.
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _webManager.CloseWebBrowser();
        }
    }
}