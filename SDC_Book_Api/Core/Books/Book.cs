namespace Core.Books
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;


        //public void Persist(BookRepository bookRepository)
        //{

        //}
        public Book(string title, string isbn)
        {
            this.Title = title;
            this.ISBN = isbn;   
        }
        public List<string> Authors { get; set; } = new List<string>();
    }
}
