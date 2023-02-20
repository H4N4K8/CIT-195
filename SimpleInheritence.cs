using System;

namespace Inheritance
{

    // base class
    class Person
    {
        public string name;
        public string age;
        public string favorite;

        // constructor
        public Person()
        {
            name = "";
            age = "";
            favorite = "";
            food = "";
            show = "";
            animal = "";

        }
        //parameterized constructor
        public Person(string name, string age, string favorite, string food, string show, string animal)
        {
            this.name = name;
            this.age = age;
            this.favorite = favorite;
            this.food = food;
            this.show = show;
            this.animal = animal;

        }

        public void display()
        {
            Console.WriteLine($"I am a person, my name is {name}");
            
        }

    }

    // derived class of persom
    class Me : Person
    {
        public void info()
        {
            Console.WriteLine("Here's your info");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Favorite thing: {favorite}");
        }
    }
    class Favorites : Person
    {
        public void favInfo()
        {
            Console.WriteLine("Here's your favorite things");
            Console.WriteLine($"Food: {food}");
            Console.WriteLine($"Show: {show}");
            Console.WriteLine($"Animal: {animal}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Person myself = new Person();
            Console.WriteLine("What is your name?");
            myself.name = Console.ReadLine();
            Console.WriteLine("What is your age?")
            myself.age = Console.ReadLine();
            Console.WriteLine("What is your favorite thing?");
            myself.favorite = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            myself.food = Console.ReadLine();
            Console.WriteLine("What is your favorite show?");
            myself.show = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            myself.animal = Console.ReadLine();
            myself.display();
            myself.info();
            myself.favInfo();
    }
}