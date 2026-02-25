using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two number");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Before Swapping " + a +" " + b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After a swapping " + a + " " + b);

    }
}