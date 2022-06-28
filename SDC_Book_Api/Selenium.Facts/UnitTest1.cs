using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Selenium.Facts
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ChromeOptions ChromeOptions = new();
            ChromeOptions.AddArgument("--headless");
            ChromeDriver webDriver = new(ChromeOptions);
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}