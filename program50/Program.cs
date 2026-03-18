using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date and Time: " + now);
        Console.WriteLine("Current Date: " + now.Date);
        Console.WriteLine("Current Time: " + now.TimeOfDay);

        Console.WriteLine("Day: " + now.Day);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Year: " + now.Year);

        Console.WriteLine("Day of Week: " + now.DayOfWeek);

        DateTime future = now.AddDays(5);
        Console.WriteLine("Date after 5 days: " + future);
    }
}