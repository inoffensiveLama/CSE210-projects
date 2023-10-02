public class Prompt{

    //Variables
    string[] _prompts = {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };
    Random _random = new Random();


    public Prompt()
    {

    }

    //mothods
    public string GetPrompt(){
        //creates a random number and returns the prompt at that specific place in the array
        int randomNumber = _random.Next(0, _prompts.Length);
        return _prompts[randomNumber];
    }
}