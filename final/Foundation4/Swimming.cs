public class Swimming : Activity
{
    private int _laps;
    private int _activityLength;

    public Swimming(string date, int activityLength, int laps) : base(date, activityLength)
    {
        SetActivityType("Swimming");
        _laps = laps;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        float time = _activityLength;
        return Math.Round(GetDistance() / (time / 60), 2);
    }
    
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2); 
    }

}