using System;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    
    public Event (string title, string description, string date, string time, string address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    

    public void DisplayStandart()
    {
        Console.WriteLine($"{_eventTitle} {_description} {_date} {_time} {_address}");
    }
    public void DisplayFull(string email, int capacity, string weather, string speaker)
    {
        Console.WriteLine($"{_eventTitle} {_description} {_date} {_time} {_address}");
        Console.WriteLine($"{email}{capacity} - {weather}{speaker}");
    }
    public void DisplayShort()
    {
     Console.WriteLine($"{_eventTitle} {_date}");   
    }

}