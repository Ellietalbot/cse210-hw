class SimpleGoal : Goal {

public override int RecordEvent()
{
    if (!_isComplete)
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        return _points;  
    }
    else
    {
        Console.WriteLine("This goal is already completed!");
        return 0;  
    }
}

       public SimpleGoal(string type, string title, string description, int points) 
        : base("Simple Goal", title, description, points) { }
}

