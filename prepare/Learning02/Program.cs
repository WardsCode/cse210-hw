using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job ();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1998;
        job1._endYear = 2005;
        job1.display();

        job job2 = new job();
        job2._jobTitle = "Web designer";
        job2._company = "Webtoon";
        job2._startYear = 1965;
        job2._endYear = 2010;
        job2.display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}