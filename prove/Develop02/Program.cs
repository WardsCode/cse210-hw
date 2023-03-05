using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your personal Journal.");
        Console.WriteLine("What you´d like to do today?");

        int menuselection = -1;
        while (menuselection != 5)
        {
        
            Console.WriteLine ("Please select one of the following options (#1-5).");
            Console.WriteLine ("1. Write");
            Console.WriteLine ("2. Display");
            Console.WriteLine ("3. Save");
            Console.WriteLine ("4. Load");
            Console.WriteLine ("5. Quit");
            string menuoption = Console.ReadLine();
            menuselection = int.Parse(menuoption);

            if (menuselection == 1)
            {

                List<string> listprompts = new List<string> ();
                listprompts.Add("What made you feel calm today?");
                listprompts.Add("Did you achieved any goal today?");
                listprompts.Add("What made you feel angry today?");
                listprompts.Add("What is the bes thing that happened to you today?");
                listprompts.Add("Tell me about that mistake you made today");
                
                List<Journal> journalsList = new List<Journal>();                      
                int promptnumber = ramdomPromptSelect.ramdomPrompt();                   
                Console.WriteLine(listprompts[promptnumber]);                           
                string promptAnswerText = Console.ReadLine();                           
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                Journal.addToJournal(listprompts[promptnumber],promptAnswerText,dateText );

            }
            else if (menuselection == 2)
            {   
                Entries.Display();
            }
            else if (menuselection == 3)
            {
                Entries.SaveFile();

            }
            else if (menuselection == 4)
            {
                Entries.LoadFile();

            }

        }
        Console.WriteLine ("Thank you for using your personal Journal.");
        Console.WriteLine ("Have a great day!");
    }
}