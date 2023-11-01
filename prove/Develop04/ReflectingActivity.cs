public class ReflectingActivity : Activity{

    //Attributes
    private List<string> _PROMPTS = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _QUESTIONS = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //Constructor
    public ReflectingActivity(string name, string description) : base(name, description){

    }

    //Methods
    public void Run(){
        //Display starting message and asking for the duration of the activity
        base.DisplayStartingMessage();
        

        //Display the prompts and questions.
        Console.WriteLine("Consider the following promtp:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDownTimer(5);

        Console.Clear();
        Console.Write($"> {GetRandomQuestion()} ");
        base.ShowSpinner(base._durationInSeconds / 2);
        Console.Write($"\n> {GetRandomQuestion()} ");
        base.ShowSpinner(base._durationInSeconds / 2);

        Console.WriteLine("\n");

        //display ending message and return to the menu
        base.DisplayEndingMessage();
    }

    private List<string> GetQuestions(){
        return _QUESTIONS;
    }

    private string GetRandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(0, _PROMPTS.Count);
        return _PROMPTS[randomNumber];
    }

    private string GetRandomQuestion(){
        Random random = new Random();
        int randomNumber = random.Next(0, _QUESTIONS.Count);
        return _QUESTIONS[randomNumber];
    }

}