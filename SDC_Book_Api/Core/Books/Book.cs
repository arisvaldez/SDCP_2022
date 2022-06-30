namespace Core.Books
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public List<string> Authors { get; set; } = new List<string>();
    }
}
