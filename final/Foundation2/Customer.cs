public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool isFromUS(){
        if (_address.isFromUS()){
            return true;
        } else {
            return false;
        }
    }

    public string getAddressStringFromAddress(){
        return _address.getAddressString();
    }

    public string getName(){
        return _name;
    }
    
}