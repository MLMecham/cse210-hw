using System.Collections.Concurrent;

class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string book, string problem) : base(name, topic)
    {
        _textBookSection = book;
        _problems = problem;
    }

    public string GetBook()
    {
        return _textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }









}