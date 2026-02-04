using System;
// Finding maximum number 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Two number");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        // if - else for finding a maximum number
        if(num1 > num2)
        {
            Console.WriteLine("The biggest number is " + num1);
        }
        else
        {
            Console.WriteLine("The biggest number is " + num2);
        }
        
    }
}
