public class SwimmingActivity : Activity {
    private int _numberLaps;
    private string _activityType = "Swimming";

    public SwimmingActivity(string date, float length, int laps) : base(date, length){
        _numberLaps = laps;
    }

    public override string GetSummary(){
        return ($"{base._date} {_activityType} ({base._lengthMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public override float GetDistance(){
        return (_numberLaps * 50) / 1000;
    }

    public override float GetSpeed(){
        return (GetDistance() / base._lengthMinutes) * 60;
    }

    public override float GetPace(){
        return base._lengthMinutes / GetDistance();
    }

}