using System;

// Display user details
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your current CGPA ");
        float CGPA = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your Grade");
        char grade = char.Parse(Console.ReadLine());
        //printing detail
        Console.WriteLine("Name is " + name);
        Console.WriteLine("Age is " + age);
        Console.WriteLine("Your CGPA is " + CGPA);
        Console.WriteLine("Your grade is " + grade);
    }
}