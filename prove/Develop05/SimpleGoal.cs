public class SimpleGoal : CompletableGoal{


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public SimpleGoal(string name, string description, int points, bool completion) : base(name, description, points)
    {
        _isComplete = completion;
    }

    public SimpleGoal(string savedString): base(savedString)
    {
        
    }

    public override int RecordEvent(){
        _isComplete = true;
        return _points;
    }

}