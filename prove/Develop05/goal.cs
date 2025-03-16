public class Goal {
    protected string _type;
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string goalType, string title, string description, int points){
        _type = goalType;
        _title = title;
        _description = description;
        _points = points;

    }

    public virtual int RecordEvent(){
        IsComplete();
        return 0;



    }
    public virtual string GetDetails()
{
    return $"{_title} - {_description}";
}
    public virtual void IsComplete(){
        _isComplete = true;
        
    }
    public void Display(){
        Console.Write(_isComplete);
    }
    public string GetGoalType(){
        return _type;
    }
      public string GetTitle(){
        return _title;
    }
      public string GetDescription(){
        return _description;
    }
      public int GetPoints(){
        return _points;
    }
    public bool GetCompletionStatus(){
        return _isComplete;
    }




}