using Core.Books;
using Core.Boundaries.Persistence;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Facts.Books
{
    internal class BookFacts
    {
        /*
         1- Retrieve all books throws nothing
         2- Retrieve all books are not null
         */

        private IEnumerable<Book> booksMock;
        private IBookRepository bookRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            booksMock = new List<Book>()
            {
                new Book("Titulo", "1234",new string[]{ "Feliz Bautista" })
            };

            bookRepositoryMock = Substitute.For<IBookRepository>();
            bookRepositoryMock.RetrieveAll().Returns(booksMock);
            
        }

        [Test]
        public void Persist_Throw_Nothing_When_Book()
        {
            Book book = new Book("Blanca Nieve", "ISBN", new List<string> { "Pepe", "Jose" });

            IBookRepository repository = NSubstitute.Substitute.For<IBookRepository>();

            Assert.That(() => book.Persist(repository), Throws.Nothing);
        }

        [Test]
        public void Retrieve_All_Books_Throw_Nothing()
        {
            Assert.That(() => bookRepositoryMock.RetrieveAll(), Throws.Nothing);
        }

        [Test]
        public void Retrieve_All_Books_Not_Null()
        {
            IEnumerable<Book> books = bookRepositoryMock.RetrieveAll();

            Assert.IsNotNull(books);
        }
    }
}
