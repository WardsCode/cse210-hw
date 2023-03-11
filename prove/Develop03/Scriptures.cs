using System;

public class Scriptures
{
    private string _textScripture;

    public List<Reference> _newList = new List<Reference>();
    
    public void Display()
    {
        foreach (Reference reference in _newList)
        {
            reference.Display();
        }
        Console.WriteLine(_textScripture);
    }
    public Scriptures (string textScripture)    /*Constructor*/
    {
        _textScripture = textScripture;
    }
  
}