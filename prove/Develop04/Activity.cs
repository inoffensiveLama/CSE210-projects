public class Activity{

    //Attributes
    private string _description;
    private string _name;
    protected int _durationInSeconds;

    //Constructor
    public Activity(string name, string description)
    {
        _description = description;
        _name = name;
    }

    //Methods
    private void ClearCharacters(int charCount){
        //move cursor to the left (how often is defined by charCount parameter)
        for(int i = 0; i<charCount; i++){
            Console.Write("\b");
        }

        //write blankspaces over the existing characters (how often is defined by charCount parameter)
        for(int i = 0; i<charCount; i++){
            Console.Write(" ");
        }

        //move cursor to the left (how often is defined by charCount parameter)
        for(int i = 0; i<charCount; i++){
            Console.Write("\b");
        }
    }

    protected void DisplayEndingMessage(){
        Console.WriteLine($"Well Done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed another {_durationInSeconds} seconds of the {_name}.");
        ShowSpinner(3);
    }

    protected void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"How long, in seconds, would you like for your session? ");
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();

        // Starting the activity with a "Get Ready..." message and a spinner animation.
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    protected void ShowCountDownTimer(int seconds){
        int duration = 0;
        while(seconds - duration > 0){
            Console.Write(seconds - duration);
            Thread.Sleep(1000);
            duration++;
            ClearCharacters(1);
        }
    }

    protected void ShowSpinner(int seconds){
        //shows a spinner animation in the console for the specified number of seconds
        int milliseconds = seconds * 1000;
        int delay = 500;
        int duration = 0;
        Console.Write("-");
        while(duration < milliseconds){
            ClearCharacters(1);
            switch(duration % 2000){
                case 0:
                    Console.Write("-");
                    break;
                case 500 :
                    Console.Write("\\");
                    break;
                case 1000 :
                    Console.Write("|");
                    break;
                case 1500 :
                    Console.Write("/");
                    break;
            }
            Thread.Sleep(delay);
            duration += delay;
        }

        ClearCharacters(1);
        
    }

    public void testFunction(){
        DisplayStartingMessage();
        ShowSpinner(5);
        ShowCountDownTimer(5);
        DisplayEndingMessage();
    }
    
}