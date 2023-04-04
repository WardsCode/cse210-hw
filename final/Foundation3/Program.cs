using System;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";

            Reception reception = new Reception("Reception", "a party usually held after the completion of a marriage ceremony as hospitality for those who have attended the wedding, hence the name reception: the couple receive society, in the form of family and friends, for the first time as a married couple. Hosts provide their choice of food and drink, although a wedding cake is popular.", "Feb-26", "8:00", "123 Street A, columbia, WA, 45512", "Email@email.com");
            Lectures  lecture = new Lectures("Lectures","We read books", "3-Mar", "7-12 AM", "5 street N, Bedrock, UT, 12556", "Matt Wards", 52);
            Outdoors outdoor = new Outdoors("Outdoors", "An outdoor activity somwhere", "2-April", "6-8PM", "123 apple st , treehouse, NC, 33566", "Warm and humid");

            while (selection.ToLower() != "4")
            {
            Console. WriteLine("Select one option:");
            Console. WriteLine("1. Standar Detail");
            Console. WriteLine("2. Full details");
            Console. WriteLine("3. Short description");
            Console.WriteLine("4. Quit ");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                reception.DisplayStandart();
                lecture.DisplayStandart();
                outdoor.DisplayStandart();

            }
            if (selection == "2")
            {
                reception.DisplayFull(reception.GetEmail(), lecture.GetCap(), outdoor.GetWeather(), lecture.GetSpeaker());
                lecture.DisplayFull(reception.GetEmail(), lecture.GetCap(), outdoor.GetWeather(), lecture.GetSpeaker());
                outdoor.DisplayFull(reception.GetEmail(), lecture.GetCap(), outdoor.GetWeather(), lecture.GetSpeaker());

            }
            if (selection == "3")
            {
                reception.DisplayShort();
                lecture.DisplayShort();
                outdoor.DisplayShort();
            }     
        }   
    }
}