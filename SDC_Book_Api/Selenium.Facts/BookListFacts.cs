using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Facts
{
    /*
     * 1- Validate that user can navigate to Book List page
     * 2- Validate all headers in table (ISBN, Title, Authors, Years, Tags, Available)
     * 3- If there arent any books, show "No books available" message.
     */
    public class BookListFacts
    {
        private ChromeDriver webDriver;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions ChromeOptions = new();
            ChromeOptions.AddArgument("--headless");
            webDriver = new(ChromeOptions);
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "http://localhost:4200/list";
            webDriver.Navigate();
        }

        [Test]
        public void With_Title_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement titleHeader = container.FindElement(By.Id("title-header"));

            string message = "Título";

            bool isTextCorrect = message == titleHeader.Text;

            Assert.IsTrue(titleHeader.Displayed && isTextCorrect);
        }

        [Test]
        public void With_ISBN_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement isbnHeader = container.FindElement(By.Id("isbn-header"));

            string message = "ISBN";

            bool isTextCorrect = message == isbnHeader.Text;

            Assert.IsTrue(isbnHeader.Displayed && isTextCorrect);

        }

        [Test]
        public void With_Author_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement authorHeader = container.FindElement(By.Id("author-header"));

            string message = "Autor(es)";

            bool isTextCorrect = message == authorHeader.Text;

            Assert.IsTrue(authorHeader.Displayed && isTextCorrect);

        }

        [Test]
        public void With_Year_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement yearHeader = container.FindElement(By.Id("year-header"));

            string message = "Año";

            bool isTextCorrect = message == yearHeader.Text;

            Assert.IsTrue(yearHeader.Displayed && isTextCorrect);

        }

        [Test]
        public void With_Tags_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement tagsHeader = container.FindElement(By.Id("tags-header"));

            string message = "Tags";

            bool isTextCorrect = message == tagsHeader.Text;

            Assert.IsTrue(tagsHeader.Displayed && isTextCorrect);
        }

        [Test]
        public void With_Available_Header_Throw_Nothing()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));

            IWebElement tagsHeader = container.FindElement(By.Id("available-header"));

            string message = "Disponible";

            bool isTextCorrect = message == tagsHeader.Text;

            Assert.IsTrue(tagsHeader.Displayed && isTextCorrect);
        }

        [Test]
        public void With_Join_To_Book_List_Page()
        {
            IWebElement container = webDriver.FindElement(By.Id("books-table-container"));
            bool isContainerVisible = container.Displayed;

            Assert.IsTrue(isContainerVisible);
        }

        [Test]
        public void With_Not_Books_Show_In_Table()
        {
            IWebElement totalBooks = webDriver.FindElement(By.Id("total-books"));

            bool areNotBooksAvaliable = totalBooks.Text == "Listado de libros (0)";

            if (areNotBooksAvaliable)
            {
                IWebElement notElementsContainer = webDriver.FindElement(By.Id("no-books-message"));
                string message = "No hay libros disponibles";
                bool isMessageValid = notElementsContainer.Text == message;

                Assert.IsTrue(isMessageValid);
            }

            Assert.Pass();
        }

        [Test]
        public void With_Books_Show_In_Table()
        {
            IWebElement totalBooks = webDriver.FindElement(By.Id("total-books"));

            bool areBooksAvailable = totalBooks.Text != "Listado de libros (0)";

            if (areBooksAvailable)
            {
                IWebElement firstElementInTable = webDriver.FindElement(By.Id("1-book-row"));

                Assert.IsTrue(firstElementInTable.Displayed);
            }

            Assert.Pass();
        }

        [Test]
        public void Press_Back_Button_Move_Register_Form()
        {
            IWebElement backButton = webDriver.FindElement(By.Id("back-button"));
            
            backButton.Click();

            bool moveBackPage = webDriver.Url == "http://localhost:4200/";

            Assert.IsTrue(moveBackPage);

        }

        [TearDown]
        public void Cleandriver()
        {
            webDriver.Close();

            webDriver.Dispose();
        }
    }
 
}
