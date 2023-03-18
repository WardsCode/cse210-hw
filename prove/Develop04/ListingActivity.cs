using System;
using System.Timers;

public class ListingActivity : Activity
{
    private string _title;
    private string _description;

    public ListingActivity()
    {
        _title = "Listing Activity";
        _description = "This Activity will help you reflect on the good things in your life by making a list of them. ";

    }

    public void DisplaySummary()
    {
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine(_description);
    }

    public void StartListenAct(int seconds)
    {
        int counterSec = seconds;
        Console.WriteLine("List as many responses you can to the following questions: ");
        List<string> listquest = new List<string> ();
                listquest.Add("Who are people that you appreciate?");
                listquest.Add("What are personal strengths of yours?");
                listquest.Add("Who are people that you have helped this week?");
                listquest.Add("When have you felt the Holy Ghost this month?");     
                listquest.Add("Who are some of your personal heroes?");              
                int promptnumber = ramdomPromptSelect.ramdomPrompt();                   
                Console.WriteLine($"---{listquest[promptnumber]}---");
                GetReady();  
                Console.WriteLine();      
        DateTime startime = DateTime.Now;
        DateTime futureTime = startime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
        Console.Write("> ");
        string listing = Console.ReadLine();
        currentTime = DateTime.Now;
        }         
        Console.WriteLine("Well done!");
        Console.WriteLine($"You´ve completed {counterSec} seconds of your breathing activity.");
        Thread.Sleep(3000);

        
        

    }



}