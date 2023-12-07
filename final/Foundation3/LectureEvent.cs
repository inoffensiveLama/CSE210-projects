public class LectureEvent : Event {
    private string _speaker;
    private int _capacity;
    private string _eventType = "Lecture Event";

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacitiy) : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacitiy;
    }


    public override string ToStringFullDetails(){
        return ($"{base._title}\n\n{base._description}\n\non the {base._date}\nat {base._time}\n\nAddress:\n{base._address.ToString()}\n\nOur Speaker:\n{_speaker}\n\nAvailable seats: {_capacity}");
    }

    public override string ToStringShort(){
        return ($"{_eventType}: {base._title}\non the {base._date}");
    }



}