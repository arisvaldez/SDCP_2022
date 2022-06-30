namespace Core.Books
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public IEnumerable<string> Authors { get; set; } = new List<string>();


        //public void Persist(BookRepository bookRepository)
        //{

        //}
        public Book(string title, string isbn, IEnumerable<string> authors)
        {
            ValidateAuthorsIsValid(authors);

            Title = title;
            ISBN = isbn;   
            Authors = authors;
        }

        private void ValidateAuthorsIsValid(IEnumerable<string> authors)
        {
            bool isAuthorValid = authors == null || !authors.Any();

            if (isAuthorValid)
            {
                throw new ArgumentNullException(nameof(authors));
            }
        }
    }
}
