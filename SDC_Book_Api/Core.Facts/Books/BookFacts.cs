using Core.Books;
using Core.Boundaries.Persistence;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Facts.Books
{
    internal class BookFacts
    {
        [Test]
        public void Persist_Throw_Exception_When_Title_Is_Null()
        {
            Book book = new Book(null, "ISBN");

            IBookRepository repository = NSubstitute.Substitute.For<IBookRepository>();

            Assert.Throws<ArgumentNullException>(() => book.Persist(repository));
            
        }

    }
}
