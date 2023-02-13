using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers to generate?");
        int size = Console.ReadLine();
        Random r = new Random();
        int[] numbers = { r.Next(1, 10) * size};
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");

    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total * number;
        }
    }
}
