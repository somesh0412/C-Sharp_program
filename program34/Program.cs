using System;

public class LoopDemo
{
    public static void Main()
    {
        Console.WriteLine("--- Starting C# Loop (1 to 10) ---");

        for (int i = 1; i <= 10; i++)
        {
            
            if (i % 2 == 0)
            {
                continue; 
            }

            
            if (i == 9)
            {
                Console.WriteLine("Break hit at 9. Exiting...");
                break;
            }

            
            Console.WriteLine($"Processing Odd Number: {i}");
        }

        
    }
}