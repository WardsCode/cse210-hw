using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();            /*to creat an instance but with thec constructor 1 (?)*/
        fraction1.getTop(15);
        fraction1.getBottom(6);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction fraction2 = new Fraction(8);
        fraction2.getBottom(2);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(20,5);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());




        




    }
}