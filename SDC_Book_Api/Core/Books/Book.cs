using Core.Boundaries.Persistence;

namespace Core.Books
{
    public class Book
    {
        public string Title { get; } = string.Empty;
        public string ISBN { get; } = string.Empty;
        public IEnumerable<string> Authors { get; } = new List<string>();

        public Book(string title, string isbn, IEnumerable<string> authors)
        {

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("El titulo no puede estar nulo ni vacio");
            }

            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentNullException("El ISB no puede estar nulo ni vacio");
            }
            
            if (authors == null)
            {
               throw new ArgumentNullException(nameof(authors));    
            }


            this.Title = title;
            this.ISBN = isbn;
              this.Authors = authors;
        }

        public void Persist(IBookRepository bookRepository)
        {
            bookRepository.Persist(this);
        }
    }
}
