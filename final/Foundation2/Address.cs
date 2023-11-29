public class Address {
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetName, string city, string state, string country){
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isFromUS(){
        if(_country == "United States"){
            return true;
        } else {
            return false;
        }
    }

    public string getAddressString(){
        return ($"{_streetName}\n{_city}\n{_state}\n{_country}");
    }
}