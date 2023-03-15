using System;

public class WrittingAssigment : Assigment
{
    private string _title;

    public WrittingAssigment(string name, string topic, string title) : base (name, topic)
    {
        _title = title;
    }

    public string GetWrittingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";

    }

} 