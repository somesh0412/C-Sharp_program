using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers in the range:");

        for (int num = start; num <= end; num++)
        {
            if (num < 2)
                continue;

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(num + " ");
        }
    }
}