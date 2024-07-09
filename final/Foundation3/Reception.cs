public class Reception : Event
{
    private string _RSVPemail;
    private int _capacity;
    private string _dressCode;

    public Reception(string RSVPemail, int capacity, string dressCode, string eventTitle, string description, Address address, int year, int month, int day, int hour, int minute) : base(eventTitle, description, address, year, month, day, hour, minute)
    {
        _RSVPemail = RSVPemail;
        _capacity = capacity;
        _dressCode = dressCode;
    }

    public void DisplayFullDetails()
    {
        int labelWidth = 25;
        Console.WriteLine($"{"Event Title:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"RSVP email:".PadRight(labelWidth)} {_RSVPemail}");
        Console.WriteLine($"{"Event Capacity:".PadRight(labelWidth)} {_capacity}");
        Console.WriteLine($"{"Dress Code:".PadRight(labelWidth)} {_dressCode}");
        Console.WriteLine($"{"Where:".PadRight(labelWidth)} {_address.GetAddressInfo()}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");   
        Console.WriteLine($"{"Description:".PadRight(labelWidth)} {_description}");
 }
    public void DisplayShortDetails()
    {
        int labelWidth = 25; 

        Console.WriteLine($"{"Reception:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");
    }
}