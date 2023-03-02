public class job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = -1;
    public int _endYear = -1;

    public job ()
    {

    }

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}.");
    }
}