using System;

class Program
{
    static void Main(string[] args)
    {
        Excersise excersise = new Excersise();
        Running running = new Running();
        Stationary stationary = new Stationary();
        Swimming swimming = new Swimming();

        string selection = "";
        while (selection.ToLower() != "5")
        {
        Console. WriteLine("Select one option:");
        Console. WriteLine("1. Track Running");
        Console. WriteLine("2. Track Stationary Bicy");
        Console. WriteLine("3. Track Swimming");
        Console. WriteLine("4. Show Summary Records ");
        Console. WriteLine("5. Quit ");

        selection = Console.ReadLine();
        string date;
        int minutes;
        string minutestxt;

        if (selection == "1")
        { 
            Console.WriteLine("Please enter Date (dd/mm/yy):");
            date = Console.ReadLine();
            running.SetDate(date);
            Console.WriteLine("Please enter minutes:");
            minutestxt = Console.ReadLine();
            minutes = int.Parse(minutestxt);
            running.SetMinutes(minutes);
            Console.WriteLine("Please enter distance running:");
            string distance = Console.ReadLine();
            running.SetDistance(distance);
        }
        else if (selection == "2")
        {
            Console.WriteLine("Please enter Date (dd/mm/yy):");
            date = Console.ReadLine();
            stationary.SetDate(date);
            Console.WriteLine("Please enter minutes:");
            minutestxt = Console.ReadLine();
            minutes = int.Parse(minutestxt);
            stationary.SetMinutes(minutes);
            Console.WriteLine("Please enter stationay speed:");
            string speed = Console.ReadLine();
            stationary.SetSpeed(speed);
        }
        else if (selection == "3")
        {
            Console.WriteLine("Please enter Date (dd/mm/yy):");
            date = Console.ReadLine();
            swimming.SetDate(date);
            Console.WriteLine("Please enter minutes:");
            minutestxt = Console.ReadLine();
            minutes = int.Parse(minutestxt);
            swimming.SetMinutes(minutes);
            Console.WriteLine("Please enter laps completed:");
            string laps = Console.ReadLine();
            swimming.SetLaps(laps);
        }

        else if (selection == "4")
        {
            running.Display();
            swimming.Display();
            stationary.Display();
        }

        }
    }
}