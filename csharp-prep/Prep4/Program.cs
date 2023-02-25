using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers;
        numbers = new List<int> ();
        int counterstop = -1;

        while (counterstop != 0)
        {
            Console.WriteLine("Enter a list of number and enter 0 to finish");
            string toaddnumber = Console.ReadLine();
            int listnumber = int.Parse(toaddnumber);
            numbers.Add (listnumber);
            counterstop = listnumber;

        }
        int sum = 0;
        foreach (int i in numbers)
        {
            sum = sum + i;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}