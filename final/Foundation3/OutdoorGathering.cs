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

    }
    public void DisplayShortDetails()
    {
        
    }
}