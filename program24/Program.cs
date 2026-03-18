using System;

class Program
{
    static void Main()
    {
        double length, width, area;

        Console.Write("Enter length of rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        area = length * width;

        Console.WriteLine("Area of Rectangle: " + area);
    }
}