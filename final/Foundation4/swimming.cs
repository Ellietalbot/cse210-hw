class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, string type, int duration, double laps) 
        : base(date, type, duration)
    {
        _laps = laps;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; 
    }

    public override double GetPace()
    {
        return GetDuration() / _laps;  
    }

    public override string GetSummary()
    {
        return $"{GetDate()} {GetType()} ({GetDuration()} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per lap.";
    }
}