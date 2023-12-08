public class CyclingActivity : Activity {
    private float _speed;
    private string _activityType = "Cycling";

    public CyclingActivity(string date, float length, float speed) : base(date, length){
        _speed = speed;
    }

    public override string GetSummary(){
        return ($"{base._date} {_activityType} ({base._lengthMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public override float GetDistance(){
        return (_speed * base._lengthMinutes) / 60;
    }

    public override float GetSpeed(){
        return _speed;
    }

    public override float GetPace(){
        return base._lengthMinutes / GetDistance();
    }

}