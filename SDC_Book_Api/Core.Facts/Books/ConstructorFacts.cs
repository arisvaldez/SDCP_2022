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
        public void With_WhithSpace_Authors_Throws_ArgumentNullException()
        {
            List<string> authours = new() { " ", "  " };
            Assert.That(() => new Book(null, null, authours), Throws.ArgumentNullException);
        }
    }
}
