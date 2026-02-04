using System;

//  Addition of two number
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Two number for addition");
        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int result = Num1 + Num2;
        // printing a result 
        Console.WriteLine("The Addition is " + result);

    }
}