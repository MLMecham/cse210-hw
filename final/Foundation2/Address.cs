public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddressInfo()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public bool IsUSA()
    {
        if (_country.ToLower() == "usa" ||  _country.ToLower() == "united states" || _country.ToLower() == "united states of america" || _country.ToLower() == "us")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}