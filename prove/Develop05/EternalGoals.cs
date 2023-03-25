using System;

public class EternalGoals : Goals
{
     public EternalGoals(string title, string description, int points, string mark) : base (title, description, points)
    {

    }

     public override void Display()
    {
        Console.WriteLine( $" [{_checked}] {_title} ({_description})");
    }
}