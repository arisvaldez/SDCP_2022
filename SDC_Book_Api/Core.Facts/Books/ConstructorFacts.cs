using Core.Books;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Facts.Books
{
    [TestFixture]
    internal class ConstructorFacts
    {
        [Test]
        public void With_Null_Throws_ArgumentNullException()
        {
            Assert.That(() => new Book(null,null,new List<string>()), Throws.ArgumentNullException);
        }
    }
}
