using System;

public class Comments
{
    public string _user1;
    public string _user2;
    public string _user3;



public Comments()
{

}

public List<String> commentsList1 = new List<string>();
public List<String> commentsList2 = new List<string>();
public List<String> commentsList3 = new List<string>();

public void Display1()
{
        Console.WriteLine($"User: {_user1}");

    foreach (string list in commentsList1)
    {
        Console.WriteLine(list);
    }

}

public void Display2()
{
        Console.WriteLine($"User: {_user1}");

    foreach (string list in commentsList2)
    {
        Console.WriteLine(list);
    }

}

public void Display3()
{
       Console.WriteLine($"User: {_user1}");

    foreach (string list in commentsList3)
    {
        Console.WriteLine(list);
    }

}



}