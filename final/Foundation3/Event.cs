public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event(string eventTitle, string description, Address address, int year, int month, int day, int hour, int minute)
    {
        _eventTitle = eventTitle;
        _description = description;
        _address = address;
        _dateTime = new(year, month, day, hour, minute, 0);
    }

    public string DisplayDateTime()
    {
        // Console.Write(_dateTime.ToString("MMMM dd, yyyy"));
        // Console.Write(" at ");
        // Console.WriteLine(_dateTime.ToString("hh:mm tt"));

        return _dateTime.ToString("MMMM dd, yyyy") + " at " + _dateTime.ToString("hh:mm tt");
    }
    public void DisplayStandardDetials()
    {
        int labelWidth = 25; 

        Console.WriteLine($"{"Event:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"What:".PadRight(labelWidth)} {_description}");
        Console.WriteLine($"{"Where:".PadRight(labelWidth)} {_address.GetAddressInfo()}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");    }

}