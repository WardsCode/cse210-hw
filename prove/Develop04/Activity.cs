using System;

public class Activity
{

    public void Delay(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        for (int i = 5; i >= 1; i--)
        {            
            Console.Write(string.Format("We will start in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

 
}