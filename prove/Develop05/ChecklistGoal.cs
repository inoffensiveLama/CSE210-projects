public class ChecklistGoal : CompletableGoal{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;

    public ChecklistGoal(string name, string description, int points, int bonusAmount, int timesCompleted, int timesToComplete) : base(name, description, points)
    {
        _bonusAmount = bonusAmount;
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
    }

    public ChecklistGoal(string savedString): base(savedString)
    {
        
    }

    public override int RecordEvent(){
        return _points;
    }

    public override string ToSavedString(){
        return $"{GetType().Name}:{_name},{_description},{_points},{_isComplete},{_bonusAmount},{_timesToComplete},{_timesCompleted}";
    }

    public override string ToString(){
        return "";
    }
}