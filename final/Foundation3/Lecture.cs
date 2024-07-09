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
        int labelWidth = 25; 

        Console.WriteLine($"{"Lecture:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"What:".PadRight(labelWidth)} {_description}");
        Console.WriteLine($"{"Speaker:".PadRight(labelWidth)} {_speakerName}");
        Console.WriteLine($"{"Room Capacity:".PadRight(labelWidth)} {_capacity}");
        Console.WriteLine($"{"Length:".PadRight(labelWidth)} {_length} minutes");
        Console.WriteLine($"{"Where:".PadRight(labelWidth)} {_address.GetAddressInfo()}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");    }
    public void DisplayShortDetails()
    {
        int labelWidth = 25; 

        Console.WriteLine($"{"Lecture:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");    }
}