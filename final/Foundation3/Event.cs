public abstract class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public override string ToString()
    {
        return ($"{_title}\n\n{_description}\n\n{_date}\n{_time}\n\n{_address.ToString()}");
    }

    public abstract string ToStringFullDetails();

    public abstract string ToStringShort();

}