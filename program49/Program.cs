using System;

class Program
{
    static void Main()
    {
        int a = -10;
        int b = 5;

        Console.WriteLine("Absolute value: " + Math.Abs(a));
        Console.WriteLine("Maximum value: " + Math.Max(a, b));
        Console.WriteLine("Minimum value: " + Math.Min(a, b));
        Console.WriteLine("Square root of 16: " + Math.Sqrt(16));
        Console.WriteLine("2 raised to power 3: " + Math.Pow(2, 3));
        Console.WriteLine("Round value of 4.6: " + Math.Round(4.6));
    }
}