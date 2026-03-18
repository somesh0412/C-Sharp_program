using System;

class Program
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = 3.14 * radius * radius;

        Console.WriteLine("Area of Circle: " + area);
    }
}