public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        _address = new(address, city, state, country);
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressInfo()
    {
        return _address.GetAddressInfo();
    }

    public bool InUSA()
    {
        return _address.IsUSA();
    }
}