using Core.Books;
using Core.Boundaries.Persistence;

namespace Persistence.Repositories
{
    internal class BookRepository : IBookRepository
    {
        public Task Persist(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
