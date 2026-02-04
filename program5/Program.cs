using System;
// Even/odd finding program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num1 = int.Parse(Console.ReadLine());
        
        // if-else for even - odd
        if(num1 % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }

            
    }
}