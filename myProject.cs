using System;

namespace gameStore
{
    class game()
    {
        private string Name;
        private string Console;
        private string Type;

        public int Name()
        {
            get
            {
            return this.Name
            }
            set
            {
            this.Name;
            }
        }

        public string Console()
        {
            get
            {
            return this.Console
            }
            set
            {
            this.Console;
            }
            Console.WriteLine(Console);
        }

        public string Type()
        {
            get
            {
            return this.Type
            }
            set
            {
            this.Type;
            }
            Console.WriteLine(Type);
        }
    }
    class myStore
    {

        static void Main(string[] args)
        {
            game game1 = new game();
            game1.SetName("Final Fantasy");
            game1.SetConsole("All");
            game1.SetType("Action");

            game2 = new game();
            Console.WriteLine("Please enter the game name:");
            game2.SetName(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the console:");
            game2.SetConsole(Console.ReadLine());
            Console.WriteLine("Please enter the type:");
            game2.SetType(Console.ReadLine());

            game game3 = new game("Horizon: Forbidden West", "Playstaion", "Adventure");

            Console.WriteLine("Please enter the game name: ");
            int tempName = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the console: ");
            string tempConsole = Console.ReadLine();
            Console.WriteLine("Please enter the type: ");
            string tempType = Console.ReadLine();
            book book4 = new book(tempName, tempConsole, tempType);

            displayBooks(game1);
            displayBooks(game2);
            displayBooks(game3);
            displayBooks(game4);
        }
    }
