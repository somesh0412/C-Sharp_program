using System;

public class GradeCalculator
{
    public static void Main()
    {
        Console.Write("Enter score (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int score))
        {
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine($"Grade: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}