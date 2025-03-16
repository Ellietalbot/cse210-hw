class EternalGoal : Goal {

    public EternalGoal(string type, string title, string description, int points) 
        : base("Eternal Goal", title, description, points) { }
    public override int RecordEvent()
    {
        Console.WriteLine($"Good job! You earned {_points} points for this eternal goal.");
        return _points;  
    }
}