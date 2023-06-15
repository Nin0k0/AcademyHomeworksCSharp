using System;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main()
        {
            var library = new Library();
            var book =  new Book() { 
                Title = "Harry Potter and others",
                Publisher = "British Royal Publishing",
                Year =  2005,
                WordsCount = 160000,
                Author = "J.K. Rowling"
            };
            var book2 = new Book()
            {
                Title = "Harry Potter and others",
                Publisher = "Another Royal Publishing",
                Year = 2025,
                WordsCount = 160000,
                Author = "J.K. Rowling"
            };

            library.AddBook(book);

            library.AddBook(book2);


            Console.WriteLine(library.FindBook("Harry Potter and others"));

            library.RemoveBook(0);

            Console.WriteLine(library.FindBook("Harry Potter and others"));





        }
    }
}
