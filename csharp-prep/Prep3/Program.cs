using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string mnumber = Console.ReadLine();
        int magicnumber = int.Parse(mnumber);
        int guess = -1;          
        
        while (guess != magicnumber)
        {
            Console.WriteLine("Guess the number now ");
            string mguess = Console.ReadLine();
            guess = int.Parse(mguess);

            if (magicnumber > guess)
             {
                Console.WriteLine("A little higher");
             }
             else if (magicnumber < guess)
             {
                Console.WriteLine("A little lower");
             }

        }
        Console.WriteLine("You got it");

    }
            
        
        
}
