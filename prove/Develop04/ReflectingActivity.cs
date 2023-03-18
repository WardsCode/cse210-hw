using System;
using System.IO;

public class ReflectingActivity : Activity
{
    private string _title;
    private string _description;

    public ReflectingActivity ()
    {
        _title = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resiliance. This will helo you recognize the power you have and how you can use it in other aspects of your life.";
    }

     public void DisplaySummary()
    {   
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine(_description);
    }

    public void StartReflectAct(int seconds)
    {

    Console.WriteLine("Have 15 seconds to think about this question:");
    List<string> listprompts = new List<string> ();
                listprompts.Add("Think of a time when you stood up for someone else.");
                listprompts.Add("Think of a time when you did something really difficult.");
                listprompts.Add("Think of a time when you helped someone in need.");
                listprompts.Add("Think of a time when you did something truly selfless.");              
                int promptnumber = ramdomPromptSelect.ramdomPrompt();                   
                Console.WriteLine(listprompts[promptnumber]); 
    Delay(15);

    Console.WriteLine("Now, answer these question: ");
    List<string> listQuestions = new List<string> ();
                listQuestions.Add("Why was this experience meaningful to you?");
                listQuestions.Add("Have you ever done anything like this before?");
                listQuestions.Add("How did you get started?");
                listQuestions.Add("How did you feel when it was complete?");              
                listQuestions.Add("What made this time different than other times when you were not as successful?");              
                listQuestions.Add("What is your favorite thing about this experience?");              
                listQuestions.Add("What could you learn from this experience that applies to other situations?");              
                listQuestions.Add("What did you learn about yourself through this experience?"); 
    int counterSec = seconds;
    while(seconds > 0 ) 
    {            
                promptnumber = ramdomPromptSelect.ramdomPrompt();             
                Console.WriteLine(listQuestions[promptnumber]);
                Console.SetCursorPosition(0, Console.CursorTop);
                Thread.Sleep(12000);
                seconds = seconds - 12;
    }  

    Console.WriteLine("Well done!");
    Console.WriteLine($"You´ve completed {counterSec} seconds of your breathing activity.");
    Thread.Sleep(3000);

    }

}
public class ramdomPromptSelect
{

    public static int ramdomPrompt()
    {
    Random rnd = new Random();
    int promptNumber  = rnd.Next(0,4); 
    return promptNumber;
    }
 

}