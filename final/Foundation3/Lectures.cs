using System;

public class Lectures : Event

{
    private string _speaker;
    private int _capacity;

    public Lectures (string title, string description, string date, string time, string address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;        
    }

     public string GetSpeaker()
    {
        return _speaker;
    }
       public int GetCap()
    {
        return _capacity;
    }


}