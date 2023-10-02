using System.Xml.Linq;

public class Journal{

    //variables
    List<string> _pages = new List<string>();
    public string _filename;
    string _prompt;
    string _entry;

    public Journal()
    {

    }

    //methods
    public void LoadJournal(){
        //call method AskForFilname
        AskForFilname();
        //read the file with the _filename and save the lines to the variable _lines
        string[] lines = File.ReadAllLines(_filename);
        _pages.AddRange(lines);
    }

    public void SaveJournal(){
        //call method AskForFilname
        AskForFilname();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string line in _pages){
                //adding one line after another to the file
                outputFile.WriteLine(line);
            }
        }
    }

    public void DisplayJournal(){
        //print each line from the file _lines
        foreach (string line in _pages){
            Console.WriteLine(line);
        }
    }

    public void WriteJournal(){
        //display prompt
        Prompt Prompt = new Prompt();
        _prompt = Prompt.GetPrompt();
        Console.WriteLine(_prompt);
        //save the entry to the variable
        Console.Write(">");
        _entry = Console.ReadLine();
        //save the current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //add entry with date to array
        _pages.Add("Date: " + dateText + " - Prompt: " + _prompt);
        _pages.Add(_entry);
    }

    public void AskForFilname(){
        //ask the user for the filename and save it to the variable
        Console.Write("What is the filename? ");
        _filename = Console.ReadLine();
    }
}