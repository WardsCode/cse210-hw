using System;

public class CheckGoals : Goals
{
     public CheckGoals(string title, string description, int points) : base (title, description, points)
    {

    }

     public override void Display()
    {
        Console.WriteLine( $" [{_checked}] {_title} ({_description})");
    }
}