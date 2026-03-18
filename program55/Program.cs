using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");

        // Read array elements
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Reversed array elements:");

        // Display array in reverse order
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}