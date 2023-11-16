public class CompletableGoal : Goal{
    protected bool _isComplete;

    public CompletableGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public CompletableGoal(string savedString): base(savedString)
    {
        
    }


    public override string ToSavedString(){
        return $"{GetType().Name}:{_name},{_description},{_points},{_isComplete}";
    }

    public override string ToString(){
        if(_isComplete){
            return $"[X] {_name} ({_description})";
        }else{
            return $"[ ] {_name} ({_description})";
        }
    }
}