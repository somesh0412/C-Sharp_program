using System;

class Program
{
    static void Main()
    {
        double basic, da, hra, total;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        da = basic * 0.10;   // 10% DA
        hra = basic * 0.20;  // 20% HRA

        total = basic + da + hra;

        Console.WriteLine("DA = " + da);
        Console.WriteLine("HRA = " + hra);
        Console.WriteLine("Total Salary = " + total);
    }
}