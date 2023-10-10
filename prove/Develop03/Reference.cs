public class Reference{

    //variables
    private string _reference;

    public Reference()
    {

    }

    //methods
    public void LoadReference(){
        //read the file with the name scripture.txt and save the lines to the variable _lines, after that it saves the first line in the variable _reference
        string[] lines = File.ReadAllLines("scripture.txt");
        _reference = lines[0];
    }

    public void DisplayReference(){
        //print the _reference variable
        Console.WriteLine(_reference);
    }

}