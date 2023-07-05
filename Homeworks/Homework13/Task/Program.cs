
        using Task;

        try
        {
            var library = new Library(5);

            var book1 = new Book(1, "Mgzavris Tserilebi", "Ilia Tchavtchavadze");
            var book2 = new Book(2, "Vefkhistyaosani", "Shota Rustaveli");
            var book3 = new Book(3, "Va, Sofelo", "Zaira Arsenishvili");
            var book4 = new Book(4, "Shashvi shashvi Mayvali", "Tamta Melashvili");
            var book5 = new Book(5, "Zinka Adamiani", "Ana Kordzaia Samadashvili");
            var book6 = new Book(6, "Malina", "Ingeborg bakhmani");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            //library.AddBook(null); // ეს რომ ამოვეკომენტარო ისვრის ArgumentNullException -ს 
            //library.AddBook(book6);  // ეს რომ ამოვეკომენტარო ისვრის IndexOutOfRangeException -ს 

            var bookNumber = 3;
            var foundBook = library.GetBook(bookNumber);
            Console.WriteLine($"Book Found '{foundBook.Title}', Author: {foundBook.Author}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }