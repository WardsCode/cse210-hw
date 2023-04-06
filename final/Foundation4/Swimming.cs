using System;

public class Swimming : Excersise
{
 protected string _laps;

 public Swimming()
 {

 }

 public string GetLaps()
 {
    return _laps;
 }

 public void SetLaps(string laps)
 {
    _laps = laps;
 }

 public override void Display()
    {
        Console.WriteLine($"{_date} Swimming for: ({_minutes} minutes)- Laps: {_laps} ");
    }

}