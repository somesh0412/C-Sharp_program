using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Number is Positive");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }

        if (number > 0)
        {
            Console.WriteLine("It is a positive number");
        }
        else if (number < 0)
        {
            Console.WriteLine("It is a negative number");
        }
        else
        {
            Console.WriteLine("It is zero");
        }

        Console.WriteLine("\nSwitch Example:");
        switch (number)
        {
            case 1:
                Console.WriteLine("You entered One");
                break;
            case 2:
                Console.WriteLine("You entered Two");
                break;
            default:
                Console.WriteLine("Number is not 1 or 2");
                break;
        }
    }
}