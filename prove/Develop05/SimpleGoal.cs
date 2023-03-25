using System;

public class SimpleGoals : Goals
{

    public SimpleGoals(string title, string description, int points) : base (title, description, points)
    {
       /* _title = title;
        _description = description;
        _points = points;*/
    }

     public override void Display()
    {
      Console.WriteLine( $" [{_checked}] {_title} ({_description})");
    }
    
}