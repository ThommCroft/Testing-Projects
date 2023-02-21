namespace Selenium_Web_Testing_Sauce_Demo
{
    public class Tests
    {
        // Base URL: https://www.saucedemo.com/

        // Need the Selenium NuGet Packages with the Web Drivers for Chrome, Firefox and Edge.
        // Create the Web Page Classes with all Elements Variables and Methods. (Use SelectorsHub to help get the WebElements)
        // Create a Configuration Manager and test.dll.config File with Copy if Newer Selected.

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}