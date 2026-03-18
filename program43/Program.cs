using System;

class Program
{
    static void Main()
    {
        int? number = null;

        if (number.HasValue)
        {
            Console.WriteLine("Value is: " + number.Value);
        }
        else
        {
            Console.WriteLine("Value is null");
        }
    }
}