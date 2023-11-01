public class ListActivity : Activity{

    //Attributes
    private List<string> _PROMPTS = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //Constructor
    public ListActivity(string name, string description) : base(name, description){

    }

    //Methods
    public void Run(){
        //Display starting message and asking for the duration of the activity
        base.DisplayStartingMessage();
        
        Console.WriteLine($"List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write($"You may begin in: ");
        base.ShowCountDownTimer(5);

        List<string> listOfResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._durationInSeconds);
        Console.WriteLine();

        while(DateTime.Now < endTime){
            Console.Write(">");
            listOfResponses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {listOfResponses.Count} items!\n");

        base.DisplayEndingMessage();

    }

    private string GetRandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(0, _PROMPTS.Count);
        return _PROMPTS[randomNumber];
    }

}