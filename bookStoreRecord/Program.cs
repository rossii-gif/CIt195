using System;

namespace bookStoreRecord
{
    class Program
    {
        // Positional record
        public record Bookstore(int ID, string Title, string Author, double Price);

        static void Main(string[] args)
        {
            Bookstore book1 = new(1, "I'm Glad My Mom Died", "Jennette McCurdy", 15.99);
            Bookstore book2 = new(2, "A Game Of Thrones", "George R.R. Martin", 20.99);
            Bookstore book3 = new(3, "everything i know about love", "Dolly Alderton", 14.99);

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);

            Console.WriteLine();

            Console.WriteLine($"Book 1 Title: {book1.Title} - Price: ${book1.Price}");
            Console.WriteLine($"Book 2 Title: {book2.Title} - Price: ${book2.Price}");
            Console.WriteLine($"Book 3 Title: {book3.Title} - Price: ${book3.Price}");
        }
    }
}