public abstract class Activity {
    protected string _date;
    protected float _lengthMinutes;

    public Activity(string date, float length){
        _date = date;
        _lengthMinutes = length;
    }

    public abstract string GetSummary();

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

}