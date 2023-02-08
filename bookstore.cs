using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int getId()
        {
            return _Id;
        }
        public string getTitle()
        {
            return _Title;
        }
        public string getAuthor()
        {
            return _Author;
        }
        public int setId(int id)
        {
            _Id = id;
        }
        public string setTitle(string title)
        {
            _Title = title;
        }
        public string setAuthor(string author)
        {
            _Author = author;
        }

    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.setId(1);
            book1.setTitle("The Cool Goose Meets A Moose");
            book1.setAuthor("Trucie Goosie");

             book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            book2.setTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            book2.setAuthor(Console.ReadLine());

            book book3 = new book(3, "Freddy's Fantastic Folk Tales", "Freddy F. Bear");

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        static void displayBooks(book book1)
        {
        Console.WriteLine("Here's your book information");
        Console.WriteLine($"Book ID: {book1.getId()}");
        Console.WriteLine($"Book Name: {book1.getTitle()}");
        Console.WriteLine($"Author Name: {book1.getAuthor()}");
        }

    }
}
