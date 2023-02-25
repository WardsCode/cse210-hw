using System;

class Program
{
    static void Main(string[] args)
    {
        Welcomemessague();
        
        string userName = PromptName();
        int userNumber = PromptNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);


    }

    static void Welcomemessague()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptNumber()
    {
        Console.WriteLine("What is your number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }


    static void DisplayResult(string name, int result)
    {
        Console.WriteLine($"{name}, the square of your number is {result}");
    }

}