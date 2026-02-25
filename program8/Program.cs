using System;
//compound interest

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome !!!");
        Console.WriteLine("Enter 1.Principal amount \n2. Rate of interest \n3. Time of period \n4. Number of time of interest applied per time period");
        int Principal_amount  = int.Parse(Console.ReadLine());
        float Rate_of_interest = float.Parse(Console.ReadLine());
        int Time_of_period = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        double Compound_interest = (Principal_amount*(Math.Pow(1+(Rate_of_interest/100)/N,N*Time_of_period)));
        Console.WriteLine("The Compound Interset is " + Compound_interest);
    }
}