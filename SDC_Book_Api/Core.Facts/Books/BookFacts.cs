using Core.Books;
using Core.Boundaries.Persistence;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Facts.Books
{
    internal class BookFacts
    {
        [Test]
        public void Persist_Throw_Nothing_When_Book()
        {
            Book book = new Book("Blanca Nieve", "ISBN", new List<string> { "Pepe", "Jose" });

            IBookRepository repository = NSubstitute.Substitute.For<IBookRepository>();

            Assert.That(() => book.Persist(repository), Throws.Nothing);
        }
    }
}
