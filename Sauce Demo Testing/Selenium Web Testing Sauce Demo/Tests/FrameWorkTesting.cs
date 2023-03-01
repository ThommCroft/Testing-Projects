using OpenQA.Selenium.Chrome;

namespace Selenium_Web_Testing_Sauce_Demo.Tests
{
    public class FrameWorkTesting
    {
        // Git Commit Message:
        //  - Created the lowest ToHighest and Highest to Lowest Filter Checks.

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
        }

        [Test]
        public void GivenAValidLogin_LoginPage_NavigateToInventoryPage()
        {
            _webManager.LoginPage.LoginUser(standardUser, password);

            Thread.Sleep(2000);
            //_webManager.InventoryPage.WaitForPageToDisplay(); // does not seem to work.

            Assert.That(_webManager.InventoryPage.GetInventoryTitle(), Is.EqualTo("Products")); // Title Class seems to Capitalise all letters.

            Thread.Sleep(2000);

            //Assert.That(_webManager.InventoryPage.FilterProductsFromAToZ(), Is.EqualTo(_webManager.InventoryPage.GetAToZProductNames()));
            //Assert.That(_webManager.InventoryPage.FilterProductsFromZToA(), Is.EqualTo(_webManager.InventoryPage.GetZToAProductNames()));

            //Assert.That(_webManager.InventoryPage.FilterProductsFromLowestToHighest(), Is.EqualTo(_webManager.InventoryPage.GetLowToHighPrice()));
            Assert.That(_webManager.InventoryPage.FilterProductsFromHighestToLowest(), Is.EqualTo(_webManager.InventoryPage.GetHighToLowPrice()));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _webManager.CloseWebBrowser();
        }
    }
}