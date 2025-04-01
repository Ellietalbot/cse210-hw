class Running : Activity
{
    private double _distance;

    public Running(string date, string type, int duration, double distance) 
        : base(date, type, duration)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}