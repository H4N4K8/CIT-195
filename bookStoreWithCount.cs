sing System;

namespace gameStore
{
    class game
    {   private string _Name;
    private string _Console;
    private string _Type;
    public static void game()
    {
        _Name = "";
        _Console = "";
        _Type = "";
    }
    public static void game(string name, string console, string type)
    {
        _Name = name;
        _Console = console;
        _Type = type;
    }
    public string getName()
    {
        return _Name;
    }
    public string getConsole()
    {
        return _Console;
    }
    public string getType()
    {
        return _Type;
    }
    public void setName(string name)
    {
        _Name = name;
    }
    public void setConsole(string console)
    {
        _Console = console;
    }
    public void setType(string type)
    {
        _Type = type;
    }
}
class myStore
{

    static void Main(string[] args)
    {
        game game1 = new game();
        game1.setName("Final Fantasy");
        game1.setConsole("All");
        game1.setType("Action");

        game game2 = new game();
        Console.WriteLine("Please enter the game name:");
        game2.setName(int.Parse(Console.ReadLine()));
        Console.WriteLine("Please enter the console:");
        game2.setConsole(Console.ReadLine());
        Console.WriteLine("Please enter the type:");
        game2.setType(Console.ReadLine());

        game game3 = new game("Horizon: Forbidden West", "Playstaion", "Adventure");

        Console.WriteLine("Please enter the game name: ");
        int tempName = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the console: ");
        string tempConsole = Console.ReadLine();
        Console.WriteLine("Please enter the type: ");
        string tempType = Console.ReadLine();
        game game4 = new game(tempName, tempConsole, tempType);

        displayGames(game1);
        displayGames(game2);
        displayGames(game3);
        displayGames(game4);
    }
        static void displayGames(game game1)
        {
            Console.WriteLine("Here's your ga,e information");
            Console.WriteLine($"Name: {game1.getName()}");
            Console.WriteLine($"Consolee: {game1.getConsole()}");
            Console.WriteLine($"Type: {game1.getType()}");
        }
