using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 2, 4, 3, 5};
        int[] result = new int[arr.Length];
        int count = 0;
        bool isDuplicate;

        for (int i = 0; i < arr.Length; i++)
        {
            isDuplicate = false;

            for (int j = 0; j < count; j++)
            {
                if (arr[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result[count] = arr[i];
                count++;
            }
        }

        Console.WriteLine("Array after removing duplicates:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}