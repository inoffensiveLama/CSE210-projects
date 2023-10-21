public class Reference{

    //variables
    private string _reference;

    public Reference(){

    }

    public Reference(string reference)
    {
        _reference = reference;
    }

    //methods

    public string GetReference(){
        //return the _reference variable
        return _reference;
    }

    public void SetReference(string reference){
        _reference = reference;
    }

}