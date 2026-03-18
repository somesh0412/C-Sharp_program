using System;

class Program
{
    static void Main()
    {
        int num = 10;
        double result;

        result = num;
        Console.WriteLine("Implicit Casting (int to double): " + result);

        double value = 9.78;
        int number;

        number = (int)value;
        Console.WriteLine("Explicit Casting (double to int): " + number);

        string str = "123";
        int convertedNumber = Convert.ToInt32(str);
        Console.WriteLine("String to int using Convert: " + convertedNumber);
    }
}