using System.ComponentModel.DataAnnotations;

public class Reference
{
    string _book;
    int _chapter;
    int _start;
    int _end;

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_start}-{_end} ");
    }

    public void DisplaySingleReference()
    {
        Console.Write($"{_book} {_chapter}:{_start} ");
    }

    
}