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

            ValidateAuthorsIsValid(authors);

            this.Title = title;
            this.ISBN = isbn;
            this.Authors = authors;
        }
        private void ValidateAuthorsIsValid(IEnumerable<string> authors)
        {
            bool isAuthorValid = authors == null || !authors.Any() || ValidateAuthorsIsNotWhiteSpace(authors);
            
            if (isAuthorValid)
            {
                throw new ArgumentNullException(nameof(authors));
            }
        }

        public void Persist(IBookRepository bookRepository)
        {
            bookRepository.Persist(this);
        }

        public bool ValidateAuthorsIsNotWhiteSpace(IEnumerable<string> authors)
        {
            foreach (string author in authors)
            {
                if (string.IsNullOrWhiteSpace(author))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

