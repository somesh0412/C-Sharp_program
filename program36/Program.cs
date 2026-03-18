using System;

public class RandomGenerator
{
    public static void Main()
    {
        Random rng = new Random();

        for (int i = 0; i < 5; i++)
        {
            int number = rng.Next(1, 101);
            Console.WriteLine(number);
        }
    }
}