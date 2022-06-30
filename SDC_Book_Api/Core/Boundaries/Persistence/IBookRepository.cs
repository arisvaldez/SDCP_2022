using Core.Books;

namespace Core.Boundaries.Persistence
{
    public interface IBookRepository
    {
        public void Persist(Book book);
        public IEnumerable<Book> RetrieveAll();
    }
}
