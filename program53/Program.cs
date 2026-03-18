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

        int largest = arr[0];
        int smallest = arr[0];

        // Find largest and smallest
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }

            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }
        }

        Console.WriteLine("Largest element = " + largest);
        Console.WriteLine("Smallest element = " + smallest);
    }
}