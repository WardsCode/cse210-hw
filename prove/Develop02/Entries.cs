using System.Collections.Generic;
using System.IO; 

public class Entries
{
    public List<Journal> _journals = new List<Journal>();
    

    public static void Display()
    {
        Console.WriteLine(" ");
        foreach(Journal i in _journals)                     /* I am not understanding how static and non static works here.*/ 
            {
                Console.WriteLine(i);
            }
        Console.WriteLine(" ");
    }

    public void SaveFile()
    {
        string JournalSaved = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(JournalSaved))
        {
            outputFile.WriteLine(_journals);                /*I assume this is how it works...*/
        }
    }

    public static void LoadFile()                           /* I dont understand how this works*/
    {
        
        string JournalLoad = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(JournalLoad);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
}
    }
}
