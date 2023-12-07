public class ReceptionEvent : Event {
    private string _email;
    private string _eventType = "Reception Event";

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address){
        _email = email;
    }


    public override string ToStringFullDetails(){
        return ($"{base._title}\n\n{base._description}\n\non the {base._date}\nat {base._time}\n\nAddress:\n{base._address.ToString()}\n\nPlease let us know if you can make it:\n{_email}");
    }

    public override string ToStringShort(){
        return ($"{_eventType}: {base._title}\non the {base._date}");
    }



}