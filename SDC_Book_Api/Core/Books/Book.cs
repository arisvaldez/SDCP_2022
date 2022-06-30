using Core.Boundaries.Persistence;

namespace Core.Books
{
    public class Book
    {
        public string Title { get; } = string.Empty;
        public string ISBN { get; } = string.Empty;


        public Book(string title, string isbn)
        {

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("El titulo no puede estar nulo ni vacio");
            }

            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentNullException("El ISB no puede estar nulo ni vacio");
            }

            this.Title = title;
            this.ISBN = isbn;
        }

        public void Persist(IBookRepository bookRepository)
        {
            bookRepository.Persist(this);
        }
    }
}
