using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment( "Matthew Wards", "Electronics");               
        Console.WriteLine(assigment1.GetSumary());
        Console.WriteLine();
        MathAssigment math1 = new MathAssigment("7.3", "8-19", "Ethan", "Math");   
        Console.WriteLine(math1.GetSumary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();
        WrittingAssigment write1 = new WrittingAssigment("Seth", "Chemistry", "The Twelve");
        Console.WriteLine(write1.GetSumary());
        Console.WriteLine(write1.GetWrittingInfo());

    }
}