using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text.Json;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] _books ;
        private int numberOfBooks;
        public Library()
        {
            _books = new Book[10]; 
            numberOfBooks = 0;
        }

        public Book this[int i]
        {
            get {

                if (ValidateIndex(i))
                {
                    return _books[i];

                }
                else
                {
                    Console.WriteLine("Index does not ex");
                    return null;
                }
                

            }
            set { _books[i] = value; }
        }
        public int Count
        {
            get { return _books.Length; }
        }

        public void AddBook(Book book)
        {
            if (numberOfBooks == _books.Length)
            {
                Book[] newBooks = new Book[_books.Length + 10];
                System.Array.Copy(_books, 0, newBooks, 0, _books.Length);
                _books = newBooks;
            }

            _books[numberOfBooks] = book;
            numberOfBooks++;

        }

        public void RemoveBook(int index)
        {
            if (ValidateIndex(index))
            {
                if (_books.Length != 0 && _books is not null)
                {
                    _books = Array.FindAll(_books, x => x != null && _books[index] == x).ToArray();
                    Console.WriteLine("Book Removed succefully!");
                };
            }
            else
            {
                Console.WriteLine("This operation can not be executed! INvalid Index!");
            }
            
        }

        public string FindBook(string searchString)
        {
            string result = null;
            var count = _books.Length;
            Book[] arrayOfFiltered = Array.FindAll(_books, x => x != null && 
            (x.Title == searchString || x.Publisher ==searchString          
            || x.Author ==searchString || x.Year.ToString()==searchString
            )).ToArray();


            foreach (var item in arrayOfFiltered)
            {
                if (item != null)
                {
                    result += JsonConvert.SerializeObject(item, Formatting.Indented).ToString();
                }
               
            }

            
            if (result != null)
            {
                return result;
            }
            return "No Books Found";
           

        }

        private bool ValidateIndex(int i)
        {
            return i < _books.Length && i >= 0;
        }
    }
}
