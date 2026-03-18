using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int element;
        bool found = false;

        Console.WriteLine("Enter 5 elements:");

        // Read array elements
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        element = Convert.ToInt32(Console.ReadLine());

        // Search element
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                Console.WriteLine("Element found at position: " + (i + 1));
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found");
        }
    }
}