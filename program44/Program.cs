using System;

class Program
{
    static void Main()
    {
        var number = 10;      // compiler treats it as int
        var name = "Somesh";  // compiler treats it as string

        Console.WriteLine("Number = " + number);
        Console.WriteLine("Name = " + name);
        // using dynamic
        dynamic value = 10;
        Console.WriteLine("Value = " + value);

        value = "Hello";
        Console.WriteLine("Value = " + value);

        value = 5.5;
        Console.WriteLine("Value = " + value);
    }
}