public class ChecklistGoal : CompletableGoal{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;

    public ChecklistGoal(string name, string description, int points, int bonusAmount, int timesToComplete) : base(name, description, points)
    {
        _bonusAmount = bonusAmount;
        _timesCompleted = 0;
        _timesToComplete = timesToComplete;
    }

    public ChecklistGoal(string name, string description, int points, bool completed, int bonusAmount, int timesToComplete, int timesCompleted) : base(name, description, points)
    {
        _bonusAmount = bonusAmount;
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _isComplete = completed;
    }

    public ChecklistGoal(string savedString): base(savedString)
    {
        
    }

    public override int RecordEvent(){
        _timesCompleted++;
        if (_timesCompleted == _timesToComplete){
            _isComplete = true;
            return _bonusAmount + _points;
        }else{
            return _points;
        }
        
    }

    public override string ToSavedString(){
        return $"{GetType().Name}:{_name},{_description},{_points},{_isComplete},{_bonusAmount},{_timesToComplete},{_timesCompleted}";
    }

    public override string ToString(){
        if (_isComplete){
            return $"[X] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}";
        } else {
            return $"[ ] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}";
        }
    }
}