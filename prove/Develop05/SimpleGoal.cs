public class SimpleGoal : CompletableGoal{


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public SimpleGoal(string savedString): base(savedString)
    {
        
    }

    public override int RecordEvent(){
        return _points;
    }

    public override string ToSavedString(){
        return "";
    }

    public override string ToString(){
        return "";
    }
}