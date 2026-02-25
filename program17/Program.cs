using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int count = 0;
        int temp = num;

        if (temp == 0)
        {
            count = 1;   
        }
        else
        {
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }
        }

        Console.WriteLine("Number of digits = " + count);
    }
}