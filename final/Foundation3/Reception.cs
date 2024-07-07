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

    }
    public void DisplayShortDetails()
    {
        
    }
}