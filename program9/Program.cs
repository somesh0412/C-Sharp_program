using System;
// biggest number from 3 number
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Three Number");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        if(a > b && a > c)
        {
            Console.WriteLine("The biggest number is " + a);
        }
        else if(b > a && b > c)
        {
            Console.WriteLine("The biggest number is " + b);
        }
        else
        {
            Console.WriteLine("The biggest number is " + c);
        }
    }
}