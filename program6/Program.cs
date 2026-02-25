using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num1 = int.Parse(Console.ReadLine());

        if (num1 > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is negative");
        }
    }
}
