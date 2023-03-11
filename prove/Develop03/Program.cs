using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your scripture memorizing app. We will help you learn a new scripture.");
        Console.WriteLine("Let´s start...");
        Console.WriteLine("Tell me what is the book: ");
        string bookName = Console.ReadLine();
        Console.WriteLine("Now, tell me what is the chapter: ");
        string chapterName = Console.ReadLine();
        Console.WriteLine("Now, is there just one verse? (Yes/No)");
        string questionAnswer = Console.ReadLine();
        Reference reference1 = null;        /*will this work?*/
        if (questionAnswer.ToLower() == "no"  )
        {
            Console.WriteLine("What is the starting verse?");
            string startVerse = Console.ReadLine();
            Console.WriteLine("And what is the ending verse?");
            string endVerse = Console.ReadLine();

            reference1 = new Reference(bookName,chapterName,startVerse,endVerse );
        }
        else 
        {
            Console.WriteLine("What is the verse?");
            string uniqueVerse = Console.ReadLine();

            reference1 = new Reference(bookName,chapterName,uniqueVerse);
        }
        
        /*Now add the scripture*/
        Console.WriteLine ("Great, lets add the scripture now: ");
        string textScripture = Console.ReadLine();

        Scriptures scriptureText = new Scriptures(textScripture);
        scriptureText._newList.Add(reference1);              
        scriptureText.Display();  /*pasar al while*/
        Console.WriteLine("Great! Lets start memorizing!");
        int counter= 0;
        string enterLoop = "";
        while (enterLoop.ToLower() != "quit")
        {   
            
            Console.WriteLine("Press 'enter' to continue, 'quit' to finish "); /*ClearLine*/
            enterLoop = Console.ReadLine();
            Hide hidewords = new Hide(textScripture);
            hidewords.ClearLine(counter);
            counter ++;

        }
        Console.WriteLine("You did great! Good bye!");
        
        

        





    }
}