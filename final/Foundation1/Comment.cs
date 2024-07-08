using System.Runtime.InteropServices.Marshalling;

class Comment
{
    private string _name;
    private string _commentText;
    private DateTime _postDate;

    public Comment(string name, string commentText, int year, int month, int day)
    {
        _name = name;
        _commentText = commentText;
        _postDate = new(year, month, day);
    }

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
        _postDate = DateTime.Today;
    }

    public string CalculateCommentAge()
    {
   
        DateTime now = DateTime.Today;;
        TimeSpan difference = now - _postDate;
        return $"Uploaded {difference.TotalDays} days ago";
    
    }

    public void DisplayComment()
    {
        Console.WriteLine();
        Console.WriteLine($"Author: {_name}\nComment: {_commentText}");
        Console.WriteLine(CalculateCommentAge());
    }

}