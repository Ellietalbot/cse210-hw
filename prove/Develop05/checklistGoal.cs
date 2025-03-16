class ChecklistGoal : Goal {
    private int _timesToCompletion;
    private int _timesCompleted;
    private int _bonus;




    public ChecklistGoal(string type, string title, string description, int points, int TimesToCompletion, int TimesCompleted, int bonus) 
        : base("Checklist Goal", title, description, points) { 
        _timesToCompletion = TimesToCompletion;
        _timesCompleted = TimesCompleted;
        _bonus = bonus;
    }


   public override int RecordEvent()
    {
        _timesCompleted++;  
        Console.WriteLine($"Progress: {_timesCompleted}/{_timesToCompletion} times completed!");

        if (_timesCompleted < _timesToCompletion)
        {
            Console.WriteLine($"Nice! You earned {_points} points.");
            return _points; 
        }
        else if (_timesCompleted == _timesToCompletion)
        {
            Console.WriteLine($"🎉 Congrats! You finished this checklist goal and earned {_points + _bonus} points (Bonus included!).");
            _isComplete = true;
            return _points + _bonus;  
        }
        else
        {
            Console.WriteLine("You've already completed this goal — no more points.");
            return 0; 
        }
    }

    public int GetCurrentCount(){
        return _timesCompleted;
    }   
    public int GetTargetCount(){
        return _timesToCompletion;
    }
    public int GetBonusPoints(){
        return _bonus;
    }
}