using System;

public class Running : Excersise
{
 protected string _distance;

 public Running()
 {

 }

    public string GetDistance()
    {
        return _distance;
    }

    public void SetDistance( string distance )
    {
        _distance = distance;
    }
    public override void Display()
    {
        Console.WriteLine($"{_date} Running ({_minutes} minutes)- Distance: {_distance} miles");
    }
}