using System;

class Program
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main()
    {
        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);
        Console.WriteLine("Numeric value: " + (int)today);
    }
}