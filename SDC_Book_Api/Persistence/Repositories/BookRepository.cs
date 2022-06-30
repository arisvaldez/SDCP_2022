using Core.Books;
using Core.Boundaries.Persistence;

namespace Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {

        private static List<Book> Books = new List<Book>()
        {

            new Book("negra nieves", "978-0-99-702542-1", new List<string>(){"Pepe"}),
            new Book("White girls", "978-0-99-702540-1", new List<string>(){"Pepe"}),

             new Book("pedro pica piedra", "978-0-99-702449-1", new List<string>(){"Pepe"}),
               new Book("i-c-k-k-c-k", "977-0-99-702549-1", new List<string>() { "Pepe" }),
                new Book("pedro suape", "979-0-99-702549-1", new List<string>() { "Pepe" })
        };


        public void Persist(Book book)
        {
            Books.Add(book);
        }

        public IEnumerable<Book> RetrieveAll()
        {
            return Books;
        }

        public int BooksLenght()
        {
            return Books.Count;
        }
    }
}
