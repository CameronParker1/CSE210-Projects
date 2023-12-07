public class OutdoorGathering : Event 
{
    private string _dayOfWeek;
    private string _temp;

    public OutdoorGathering(string dayOfWeek, string temp)
      
      : base("State Fair","This is the annual Texas State Fair","Held on 8/18/23","From 9 AM to 10 PM","345 Party Place","Austin","Texas","United States")
    {
        _dayOfWeek = dayOfWeek;
        _temp = temp;
        SetEventType("Event Type: Outdoor Gathering");
    }

    public string GetForecast()
    {
        return $"The weather forecast for {_dayOfWeek} is {_temp}°F \n";
    }
}