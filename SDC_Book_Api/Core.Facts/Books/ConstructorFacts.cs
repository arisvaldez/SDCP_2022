using Core.Books;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Facts.Books
{
    [TestFixture]
    internal class ConstructorFacts
    {
        [Test]
        public void With_Null_Authors_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null,null,null), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Empty_Authors_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null, null, new List<string>()), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Null_Title_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null, null, null), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Empty_Title_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book("", null, null), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Null_ISBN_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null, null, null), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Empty_ISBN_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null, "", null), Throws.ArgumentNullException);
        }
    }
}
