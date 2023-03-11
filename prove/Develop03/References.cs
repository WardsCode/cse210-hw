using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    private string _verseUnique;


    public Reference(string book, string chapter, string uniqueVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseUnique = uniqueVerse;
        _verseEnd = "a";
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startVerse;
        _verseEnd = endVerse;
    }
    public void Display()
    {
        if (_verseEnd == "a")
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseUnique}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart}-{_verseEnd}");
        }
        
    }
}