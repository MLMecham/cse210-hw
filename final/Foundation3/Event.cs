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

    public void DisplayDateTime()
    {
        Console.Write(_dateTime.ToString("MMMM dd, yyyy"));
        Console.Write(" at ");
        Console.WriteLine(_dateTime.ToString("hh:mm tt"));
    }
    public void DisplayStandardDetials()
    {
        Console.WriteLine($"{_eventTitle}\n{_description}\n{_address.GetAddressInfo()}");
    }

}