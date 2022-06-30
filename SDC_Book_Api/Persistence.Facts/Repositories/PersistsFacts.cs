using Core.Books;
using NUnit.Framework;
using Persistence.Repositories;
using System.Collections.Generic;

namespace Persistence.Facts.Repositories
{
    internal class PersistsFacts
    {
        [Test]
        public void When_Persists_Throws_Nothing()
        {
            Book newBook = new Book("Pepe", "978-0-99-702549-1", new List<string>() { "PEPE" });
            BookRepository bookRepository = new BookRepository();
            Assert.That(() => bookRepository.Persist(newBook), Throws.Nothing);

        }
            

        [Test]
        public void Increase_Lenght_When_Persists()
        {
            Book newBook = new Book("Pepe", "978-0-99-702549-1", new List<string>{ "PEPE" });
            BookRepository bookRepository = new BookRepository();
            int booksLength = bookRepository.BooksLenght();

            newBook.Persist(bookRepository);

            Assert.That(() => bookRepository.BooksLenght(), Is.EqualTo(booksLength + 1));
        }
    }
}
