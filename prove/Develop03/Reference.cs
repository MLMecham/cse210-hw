using System.ComponentModel.DataAnnotations;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _start;
    private int _end;

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