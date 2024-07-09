public class OutdoorGathering : Event
{
    public string _forcast;
    public string _itemToBring;

    public OutdoorGathering(string forcast, string itemToBring, string eventTitle, string description, Address address, int year, int month, int day, int hour, int minute) : base(eventTitle, description, address, year, month, day, hour, minute)
    {
        _forcast = forcast;
        _itemToBring = itemToBring;
    }

    public void DisplayFullDetails()
    {
        int labelWidth = 25;

        Console.WriteLine($"{"Outdoor Gathering:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"What:".PadRight(labelWidth)} {_description}");
        Console.WriteLine($"{"Forecast:".PadRight(labelWidth)} {_forcast}");
        Console.WriteLine($"{"Please Bring:".PadRight(labelWidth)} {_itemToBring}");
        Console.WriteLine($"{"Where:".PadRight(labelWidth)} {_address.GetAddressInfo()}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");
            }
    public void DisplayShortDetails()
    {
        int labelWidth = 25; 

        Console.WriteLine($"{"Lecture:".PadRight(labelWidth)} {_eventTitle}");
        Console.WriteLine($"{"When:".PadRight(labelWidth)} {DisplayDateTime()}");    }
}