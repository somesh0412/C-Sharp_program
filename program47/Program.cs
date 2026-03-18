using System;

class Program
{
    static void Main()
    {
        var student = (1, "Somesh", 85.5);

        Console.WriteLine("Roll No: " + student.Item1);
        Console.WriteLine("Name: " + student.Item2);
        Console.WriteLine("Marks: " + student.Item3);
    }
}