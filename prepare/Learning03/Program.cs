using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();            /*to creat an instance but with thec constructor 1 (?)*/
        fraction1.getTop(3);
        fraction1.getBottom(8);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        


        




    }
}