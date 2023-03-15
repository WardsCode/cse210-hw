using System;

public class MathAssigment : Assigment
{
    private string _problems;
    private string _textBookSection;

    public MathAssigment(string problems, string textBookSection, string studentName, string topic ) : base (studentName, topic)
    {
        _problems = problems;
        _textBookSection = textBookSection;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}