public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _determineCountry = false;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool DetermineCountry()
    {
        if (_country == "United States")
        {
            _determineCountry = true;
        }

        else
        {
            _determineCountry = false;
        }

        return _determineCountry;
    }

    public string CreateAddress()
    {
        return $"{_streetAddress} \n{_city}, {_state} \n{_country} \n";
    }
}