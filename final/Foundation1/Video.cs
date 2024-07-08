using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList = new();
    private DateTime _uploadDate;


    public Video(string title, string author, int year, int month, int day, int length)
    {
        _title = title;
        _author = author;
        _uploadDate = new(year, month, day);
        _length = length;
        // _uploadDate = uploadDate;
    }

     public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _uploadDate = DateTime.Today;
        _length = length;
        // _uploadDate = uploadDate;
    }
    public int GetNumberOfComments()
    {
        return _commentList.Count();
    }
    public void DisplayAllVideoInfo()
    {
        Console.WriteLine(DisplayVideoInfo());
        Console.WriteLine(CalculateVideoAge());
        Console.WriteLine($"Length {_length} seconds");
    }
    public string DisplayVideoInfo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nNumber of Comments: {_commentList.Count()}";

    }
    public string CalculateVideoAge()
    {
        DateTime now = DateTime.Today;
        TimeSpan difference = now - _uploadDate;
        return $"Uploaded {difference.TotalDays} days ago";
    }
    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public void DisplayComments()
    {
        foreach (Comment comment in  _commentList)
        {
            comment.DisplayComment();

        }
    }
}