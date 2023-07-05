namespace Task
{
    public class Book
    {
        public int BookNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int bookNumber, string title, string author)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException(nameof(bookNumber), "Book must not have  null or empty parameters !");
            }

            BookNumber = bookNumber;
            Title = title;
            Author = author;
        }
    }
}
