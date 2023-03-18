using System;

class Program
{
    static void Main(string[] args)
    {
        string choise = "-1";
        while (choise != "4")
        {

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing activity ");
        Console.WriteLine("2. Start Reflecting activity ");
        Console.WriteLine("3. Start Listing activity ");
        Console.WriteLine("4. Quit ");
        Console.WriteLine("Select a choice from the menu:  ");
        choise = Console.ReadLine();

        if (choise == "1" )
        {
            BreathingActivity breath1 = new BreathingActivity ();
            breath1.DisplaySummary();
            breath1.ConsoleSpinner();
            Console.WriteLine("How long, in seconds, would you like for your session? ");
            string secondsstring = Console.ReadLine();
            int seconds = int.Parse(secondsstring);
            breath1.GetReady();
            breath1.StartBreathAct(seconds);


        }

        else if (choise == "2")
        {
            ReflectingActivity reflect1 = new ReflectingActivity();
            reflect1.DisplaySummary();
            Console.WriteLine("How long, in seconds, would you like for your session? ");
            string secondsstring = Console.ReadLine();
            int seconds = int.Parse(secondsstring);
            reflect1.GetReady();
            reflect1.StartReflectAct(seconds);

        }

        else if (choise == "3")
        {
            ListingActivity listen1 = new ListingActivity();
            listen1.DisplaySummary();
            Console.WriteLine("How long, in seconds, would you like for your session? ");
            string secondsstring = Console.ReadLine();
            int seconds = int.Parse(secondsstring);
            listen1.GetReady();
            listen1.StartListenAct(seconds);
            
        }

        Console.Clear();

        }

        Console.WriteLine("Good Job! Have a great day!");

    }
}