using System;

namespace bookStore
{
    class book()
    {
        private int Id;
        private string Title;
        private string Author;

        public int Id()
        {
            get
            {
            return this.Id
            }
            set
            {
            this.Id;
            }
        }

        public string Title()
        {
            get
            {
            return this.Title
            }
            set
            {
            this.Title;
            }
            Console.WriteLine(Title);
        }

        public string Author()
        {
            get
            {
            return this.Author
            }
            set
            {
            this.Author;
            }
            Console.WriteLine(Author);
        }
    }
    class myStore
    {

        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetId(1);
            book1.SetTitle("The Cool Goose Meets A Moose");
            book1.SetAuthor("Trucie Goosie");

             book book2 = new book();
            Console.WriteLine("Please enter the member ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the first name: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the last name: ");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book(3, "Freddy's Fantastic Folk Tales", "Freddy F. Bear");

            Console.WriteLine("Please enter the member ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first name: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the last name: ");
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
        Console.WriteLine($"Book ID: {book1.GetId()}");
        Console.WriteLine($"Book Name: {book1.GetTitle()}");
        Console.WriteLine($"Book Name: {book1.GetAuthor()}");
        }

    }
}