using System;
// simple interest 
class Progarm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome !!!!");
        Console.WriteLine("To find simple interest, Give 1. Principal amout \n, 2. Annual rate of interest(as a percentage) \n Period in year ");
        int Principal_amount = int.Parse(Console.ReadLine());
        float Rate_of_interest =  float.Parse(Console.ReadLine());
        int Time_of_period = int.Parse(Console.ReadLine());
        double Simple_interest = (Principal_amount * Rate_of_interest * Time_of_period) / 100 ;
        Console.WriteLine("Your simple interest is " + Simple_interest);
    }
}