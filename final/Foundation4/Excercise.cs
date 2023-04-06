using System;

public class Excersise
{
 protected string _date;
 protected int _minutes;

    public Excersise()
    {

    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }


    public virtual void Display()
    {

    }



}