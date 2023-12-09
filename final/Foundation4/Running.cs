public class Running : Activity
{
    private int _distance;
    private int _activityLength;

    public Running(string date, int activityLength, int distance) : base(date, activityLength)
    {
        SetActivityType("Running");
        _distance = distance;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        float time = _activityLength;
        return Math.Round(_distance / (time / 60), 2);
    }
    
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }
}