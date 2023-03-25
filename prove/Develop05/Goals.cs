using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
public class Goals
{
    //Atributes and Lists
    protected string _title;
    protected string _description;
    protected int _points;
    protected string _checked = "";
    

    //Constructor
    public Goals (string title, string description, int points) 
    {
        _title = title;
        _description = description;
        _points = points;
    }

    //Getters
    public string GetTitle()
    {
        return _title;
    }
     public string GetDescription()
    {
        return _description;
    }
     public int GetPoints()
    {
        return _points;
    }
    public string GetCheck()
    {
        return _checked;
    }

    //Setters
     public void SetTitle(string title)
    {
        _title = title;
    }
     public void SetDescription(string description)
    {
        _description = description;
    }
     public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetCheck()
    {
        _checked = "X";
    }


    // display
    public virtual void Display()
    {
       // Console.WriteLine( $" [{_checked}] {_title} ({_description})");
    }

}