public class RunningActivity : Activity {
    private float _distance;
    private string _activityType = "Running";

    public RunningActivity(string date, float length, float distance) : base(date, length){
        _distance = distance;
    }

    public override string GetSummary(){
        return ($"{base._date} {_activityType} ({base._lengthMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public override float GetDistance(){
        return _distance / 1000;
    }

    public override float GetSpeed(){
        return (GetDistance() / base._lengthMinutes) * 60;
    }

    public override float GetPace(){
        return base._lengthMinutes / _distance;
    }

}