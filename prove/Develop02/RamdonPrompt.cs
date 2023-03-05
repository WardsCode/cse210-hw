using System;

public class ramdomPromptSelect
{

    public static int ramdomPrompt()
    {
    Random rnd = new Random();
    int promptNumber  = rnd.Next(0,4); 
    return promptNumber;
    }
 

}