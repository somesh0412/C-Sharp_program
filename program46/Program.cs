using System;

struct Student
{
    public int rollNo;
    public string name;
    public int marks;
}

class Program
{
    static void Main()
    {
        Student s1;

        s1.rollNo = 1;
        s1.name = "Somesh";
        s1.marks = 85;

        Console.WriteLine("Roll No: " + s1.rollNo);
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Marks: " + s1.marks);
    }
}