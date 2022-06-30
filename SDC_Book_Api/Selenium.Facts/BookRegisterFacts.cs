using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium.Facts
{
    /* 1. All fields are required, except tags
     * 2. You can insert more than an author
     * 3. ISBN is unique
     * 4. Year is a positive integer
     */
    public class BookRegisterFacts
    {
        private ChromeDriver webDriver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions ChromeOptions = new();
            ChromeOptions.AddArgument("--headless");
            webDriver = new(ChromeOptions);
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Validate_Title_Is_Required_Show_Message()
        {
            IWebElement title = webDriver.FindElement(By.Id("title"));
            IWebElement button = webDriver.FindElement(By.Id("send"));

            title.SendKeys(string.Empty);
            button.Click();

            WebDriverWait wait = new(webDriver, TimeSpan.FromSeconds(8));

            IWebElement titleError =  wait.Until(expectCondition => expectCondition.FindElement(By.Id("title-required")));

            Assert.IsTrue(titleError.Displayed);
            bool existMessage = titleError.Text.Contains(@"El titulo es requerido");

            Assert.That(existMessage, Is.True);

        }

        [TearDown]
        public void Cleandriver()
        {
            webDriver.Close();

            webDriver.Dispose();
        }
    }
}