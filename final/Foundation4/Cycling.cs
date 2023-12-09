public class Cycling : Activity
{
    private int _speed;
    private int _activityLength;

    public Cycling(string date, int activityLength, int speed) : base(date, activityLength)
    {
        SetActivityType("Cycling");
        _speed = speed;
        _activityLength = activityLength;
    }
    
    public override double GetDistance()
    {
        return _speed * _activityLength / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

}