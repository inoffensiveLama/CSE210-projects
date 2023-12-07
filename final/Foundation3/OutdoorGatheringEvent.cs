public class OutdoorGatheringEvent : Event {
    private string _weatherForecast;
    private string _eventType = "Outdoor Gathering Event";

    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address){
        _weatherForecast = weatherForecast;
    }


    public override string ToStringFullDetails(){
        return ($"{base._title}\n\n{base._description}\n\non the {base._date}\nat {base._time}\n\nAddress:\n{base._address.ToString()}\n\nThe weather is going to be {_weatherForecast}.\nPlease dress accordingly");
    }

    public override string ToStringShort(){
        return ($"{_eventType}: {base._title}\non the {base._date}");
    }



}