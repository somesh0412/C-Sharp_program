using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number for to find factorial number ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;


        for(int i = n; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("The factorial of " + n + " is " + factorial);
    }
}