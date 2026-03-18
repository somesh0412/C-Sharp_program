using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;
        double average;

        Console.WriteLine("Enter 5 elements:");

        // Read array elements
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < 5; i++)
        {
            sum = sum + arr[i];
        }

        // Calculate average
        average = (double)sum / arr.Length;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}