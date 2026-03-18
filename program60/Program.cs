using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        int[,] result = new int[2, 2];

        Console.WriteLine("Enter elements of first matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of second matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix multiplication
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Resultant matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}