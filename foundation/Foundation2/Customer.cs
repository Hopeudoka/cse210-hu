public class Customer
{
    private string _name;
    private Address _address;

    // Add constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Add methods
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}