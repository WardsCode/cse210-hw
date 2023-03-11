
using System;
using System.IO; 

public class Journal
{
    public string _promptQuestion;
    public string _promptAnswer;
    public string _date;

    

    public Journal ()
    {

    }

    public void addToJournal(string prompt, string promptAnswer,string date)
    {
        Entries newEntry = new Entries();
            Journal journal = new Journal ();                                      
            journal._promptQuestion = prompt;
            journal._promptAnswer = promptAnswer;
            journal._date = date;
            newEntry._journals.Add (journal); 
    }

    

}
