using System;

class Program
{
    static void Main()
    {
        int[] arr1 = {1, 2, 3};
        int[] arr2 = {4, 5, 6};

        int[] merged = new int[arr1.Length + arr2.Length];

        // Copy first array
        for (int i = 0; i < arr1.Length; i++)
        {
            merged[i] = arr1[i];
        }

        // Copy second array
        for (int i = 0; i < arr2.Length; i++)
        {
            merged[arr1.Length + i] = arr2[i];
        }

        Console.WriteLine("Merged array:");

        for (int i = 0; i < merged.Length; i++)
        {
            Console.WriteLine(merged[i]);
        }
    }
}