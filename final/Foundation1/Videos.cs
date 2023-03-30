using System;

public class Videos

{
    public string _title;
    public string _author;
    public int _lenght;

    public Videos()
    {

    }


    public void Display(int counter)
    {
        Console.WriteLine($"{counter}. {_title} {_author} ({_lenght} seg)");
        
    }





    
}