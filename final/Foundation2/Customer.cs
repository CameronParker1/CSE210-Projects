using System.Runtime.Loader;

public class Customer
{
    private string _name;
    private Address _address; 
    private bool _inUS;
    public Customer(string name, string streetAddress, string city, string state, string country)
    {   
        _address = new(streetAddress, city, state, country);
        _name = name;
    }

    public bool GetCountry()
    {
        _inUS = _address.DetermineCountry();
        return _inUS;
    }

    public string CustomerAddress()
    {
        return $"\n{_name}\n{_address.CreateAddress()}";
    }


}