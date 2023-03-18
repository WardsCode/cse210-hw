using System;

public class BreathingActivity : Activity
{
    private string _title;
    private string _description;

    public BreathingActivity()
    {
        _title = "Breathing Activity";
        _description = "This activity will help you to relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DisplaySummary()
    {   
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine(_description);
    }

    public void StartBreathAct(int seconds)
    {
        int counterSec = seconds;
        while(seconds != 0 )
        {    
            for (int i = 5; i >= 1; i--)
            {            
                Console.Write($"Breath in... [{i}]");
                Console.SetCursorPosition(0, Console.CursorTop);
                Thread.Sleep(1000);
                seconds --;
            }

            if (seconds != 0)
            {
                for (int i = 5; i >= 1; i--)
                {            
                    Console.Write($"Breath out... [{i}]");
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Thread.Sleep(1000);
                    seconds --;
                }
            }
        }
        Console.WriteLine($"You´ve completed {counterSec} seconds of your breathing activity.");
        Thread.Sleep(3000);
        /*add here the spinning thing later*/
    }
        
}


