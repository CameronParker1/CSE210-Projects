public abstract class Activity 
{
    private string _date;
    private int _activityLength;
    private string _activityType; 

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }
    public abstract double GetDistance();
   

    public abstract double GetSpeed();
    

    public abstract double GetPace();
   

     public void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_activityLength} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile");
    }
}