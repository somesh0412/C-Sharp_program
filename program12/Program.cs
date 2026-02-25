using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter how many terms: ");
        int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1;

        if (n >= 1)
            Console.Write(first + " ");

        if (n >= 2)
            Console.Write(second + " ");

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }
    }
}