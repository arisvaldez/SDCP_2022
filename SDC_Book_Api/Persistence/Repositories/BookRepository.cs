using Core.Books;
using Core.Boundaries.Persistence;

namespace Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> Books
        {
            get{ return Books.GetRange(0, Books.Count); }
            private set { _ = new List<Book>(); } 
        }

        public BookRepository()
        {
            Books.Add(new Book("negra nieves", "978-0-99-702542-1", new List<string> { "Pepe" }));
            Books.Add(new Book("White girls", "978-0-99-702540-1", new List<string> { "Pepe" }));
            Books.Add(new Book("pedro pica piedra", "978-0-99-702449-1", new List<string> { "Pepe" }));
            Books.Add(new Book("i-c-k-k-c-k", "977-0-99-702549-1", new List<string> { "Pepe" }));
            Books.Add(new Book("pedro suape", "979-0-99-702549-1", new List<string> { "Pepe" }));
        }
        public void Persist(Book book)
        {
            Books.Add(book);
        }
    }
}
