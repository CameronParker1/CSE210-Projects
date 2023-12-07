using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _specifics;

    public Event(string eventTitle, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new(street, city, state, country);
    }

    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }
    public void StandardDetails()
    {
        Console.WriteLine($"Standard Details: \n{_eventTitle} \n{_description} \n{_date} \n{_time} \n{_address.CreateAddress()} \n");
    }

    public void FullDetails(string specifics)
    {
        _specifics = specifics;

        Console.WriteLine($"Full Details: \n{_eventType} \n{_eventTitle} \n{_description} \n{_date} \n{_time} \n{_address.CreateAddress()} \n{_specifics}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Short Description: \n{_eventType} \n{_eventTitle} \n{_date} \n");
    }
    
}