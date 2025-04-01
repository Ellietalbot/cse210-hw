class Activity
{
    private string _date;
    private string _activtyType;
    private double _duration;

    public Activity(string date, string type, double duration)
    {
        _date = date;
        _activtyType = type;
        _duration = duration;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
    public string GetDate(){
        return _date;
    }
    public string GetactivityType(){
        return _activtyType;
    }
    public double GetDuration(){
        return _duration;
    }


    public virtual string GetSummary()
    {
        return $"{_date} {_activtyType} ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km.";
    }
}
