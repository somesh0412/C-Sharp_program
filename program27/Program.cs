using System;

class Demo
{
    public const double PI = 3.14;
    public readonly int number;

    public Demo(int n)
    {
        number = n;
    }

    public void Display()
    {
        Console.WriteLine("Constant value PI: " + PI);
        Console.WriteLine("Readonly value number: " + number);
    }
}

class Program
{
    static void Main()
    {
        Demo obj = new Demo(100);
        obj.Display();
    }
}