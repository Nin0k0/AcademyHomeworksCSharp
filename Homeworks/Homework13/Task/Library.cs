namespace Task
{
    public class Library
    {
        private readonly List<Book> _books;
        private int Capacity { get; }

        public Library(int capacity)
        {
            Capacity = capacity;
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book must not be null!");

            if (_books.Count >= Capacity)
                throw new IndexOutOfRangeException("Library is full!");

            _books.Add(book);
            Console.WriteLine($"Book '{book.Title}' {book.BookNumber} by {book.Author} added!");
        }

        public Book GetBook(int bookNumber)
        {
            var book = _books.FirstOrDefault(b => b.BookNumber == bookNumber);
            return book ?? throw new BookNotFoundException($"Book with number {bookNumber} not fund!");
        }
    }
}
