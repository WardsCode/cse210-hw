using System;

public class Outdoors : Event
{
    private string _weather;

    public Outdoors(string title, string description, string date, string time, string address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

 

}