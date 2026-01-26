using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetId(1);
            book1.SetTitle("1984");
            book1.SetAuthor("George Orwell");

            book book2 = new book();
            Console.WriteLine("Enter book ID:");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter book title:");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Enter book author:");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book(3, "The Hobbit", "J.R.R. Tolkien");

            Console.WriteLine("Enter book ID:");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book title:");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            string tempAuthor = Console.ReadLine();

            book book4 = new book(tempId, tempTitle, tempAuthor);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        static void displayBooks(book b)
        {
            Console.WriteLine("Book Information");
            Console.WriteLine($"ID: {b.GetId()}");
            Console.WriteLine($"Title: {b.GetTitle()}");
            Console.WriteLine($"Author: {b.GetAuthor()}");
            Console.WriteLine();
        }
    }

    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
}
