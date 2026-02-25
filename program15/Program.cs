using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int original = num;
        int digits = 0;
        int temp = num;

        // Count digits
        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }

        int sum = 0;
        temp = num;

        
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }

        if (sum == original)
            Console.WriteLine("Armstrong number");
        else
            Console.WriteLine("Not an Armstrong number");
    }
}