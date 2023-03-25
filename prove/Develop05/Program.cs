using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program
{
    //Console.WriteLine("");
    static void Main(string[] args)
    {
        
        string selection = "0";
        List<Goals> goalsList = new List<Goals>();
        int pointsTotal = 0;
                    int counterLevel = 0;

        while (selection != "6" )
        {
            Console.WriteLine();
            if (pointsTotal > 100)
            {
                Console.WriteLine("You have reach a new level!");
                counterLevel ++;
                pointsTotal =  pointsTotal - 100;
            }
            Console.WriteLine($"You are level {counterLevel} and you have {pointsTotal} Points");         // add a lever up method      
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal ");
            Console.WriteLine("2. List of Goals ");
            Console.WriteLine("3. Save Goals ");
            Console.WriteLine("4. Load Goals ");
            Console.WriteLine("5. Record Event ");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option from the menu: ");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                string goalSelection;
                Console.WriteLine("");
                Console.WriteLine("Types of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Check list Goal");
                Console.WriteLine("Choose any of these: ");
                goalSelection = Console.ReadLine();

                if (goalSelection == "1")
                {   
                    Console.WriteLine("What would be the name of your goal?");
                    string title = Console.ReadLine();
                    Console.WriteLine("Give a short description");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many poinst will you earn from this goal?");
                    string pointstx = Console.ReadLine();
                    int points = int.Parse(pointstx);
                    SimpleGoals sGoal = new SimpleGoals(title, description, points);
                    goalsList.Add(sGoal);
                }
                else if (goalSelection == "2")
                {
                    Console.WriteLine("What would be the name of your goal?");
                    string title = Console.ReadLine();
                    Console.WriteLine("Give a short description");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many poinst will you earn from this goal?");
                    string pointstx = Console.ReadLine();
                    int points = int.Parse(pointstx);
                    EternalGoals eGoal = new EternalGoals(title, description, points, " ");
                    goalsList.Add(eGoal);
                }
                else if (goalSelection == "3")
                {
                    Console.WriteLine("What would be the name of your goal?");
                    string title = Console.ReadLine();
                    Console.WriteLine("Give a short description");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many poinst will you earn from this goal?");
                    string pointstx = Console.ReadLine();
                    int points = int.Parse(pointstx);
                    CheckGoals cGoal = new CheckGoals(title, description, points);
                    goalsList.Add(cGoal);
                }
            }
            else if (selection == "2")
            {
                Console.WriteLine("Your goals are: ");
                foreach (Goals goal in goalsList)
                {
                    goal.Display();
                }
            }
            else if (selection == "3")
            {
                string fileName = "myFile.txt";
                using(StreamWriter outputFile = new StreamWriter(fileName))
                {
                foreach (Goals goal in goalsList)
                {
                    outputFile.WriteLine($"{goal.GetTitle()}, {goal.GetDescription()}, {goal.GetPoints()}");
                }
                }
                Console.WriteLine("Goals have been saved.");
            }
            else if (selection == "4")
            {
            string filename = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                Goals nGoal = new Goals(parts[0], parts[1],int.Parse(parts[2]));
                goalsList.Add(nGoal);
                nGoal.Display();
            }
            
            }
            else if (selection == "5")
            {
                int counter1 = 0;
                Console.WriteLine("The goals are: ");
                foreach (Goals goal in goalsList)
                {
                    string ttl = goal.GetTitle();
                    Console.WriteLine($"{counter1}. {ttl}");
                    counter1 ++;
                }
                Console.WriteLine("Which goal did you accomplished?");
                string answer = Console.ReadLine();
                int answern = int.Parse(answer);
                goalsList[answern].SetCheck();
                int pointsToSum = goalsList[answern].GetPoints();
                pointsTotal = pointsTotal + pointsToSum;
                Console.WriteLine ($"Congratulations! You have earned {goalsList[answern].GetPoints()} points!");
            }

        }

       
        
        
    }

}