public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Add constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Add methods
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}