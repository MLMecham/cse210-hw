public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    private int _length;

    public Lecture(string speakerName, int capacity, int length, string eventTitle, string description, Address address, int year, int month, int day, int hour, int minute) : base(eventTitle, description, address, year, month, day, hour, minute)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _length = length;
    }

    public void DisplayFullDetails()
    {

    }
    public void DisplayShortDetails()
    {
        
    }
}