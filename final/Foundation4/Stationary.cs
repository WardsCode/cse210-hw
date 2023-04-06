using System;

public class Stationary : Excersise
{
 protected string _speed;

 public Stationary()
    {

    }
 public string GetSpeed()
 {
    return _speed;
 }
 public void SetSpeed(string speed)
 {
    _speed = speed;
 }
 public override void Display()
    {
        Console.WriteLine($"{_date} Stationary for: ({_minutes} minutes)- Speed: {_speed} miles/hour ");
    }

}
