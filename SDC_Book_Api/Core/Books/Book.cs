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
            if (authors == null)
            {
               throw new ArgumentNullException(nameof(authors));    
            }
            this.Title = title;
            this.ISBN = isbn;   
            this.Authors = authors;

        }
    }
}
