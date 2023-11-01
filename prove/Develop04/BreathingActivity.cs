public class BreathingActivity : Activity{

    //Attributes

    //Constructor
    public BreathingActivity(string name, string description) : base(name, description){

    }

    //Methods
    public void Run(){
        //Display starting message and asking for the duration of the activity
        base.DisplayStartingMessage();
        Console.WriteLine();
        // Calculate the number of rounds based on a fixed duration per round
        int roundDuration = 10; // Duration of each "breath in" and "breath out" round in seconds
        int numberOfRounds = (int)Math.Ceiling((double)_durationInSeconds / roundDuration);

        // Display "breath in" and "breath out" messages for the duration of the activity
        for (int i = 1; i <= numberOfRounds; i++)
        {
            if (i == numberOfRounds && _durationInSeconds % roundDuration != 0)
            {
                // Last round with a partial duration
                int lastRoundDuration = _durationInSeconds % roundDuration;
                ShowBreathInMessage(lastRoundDuration / 2);
                ShowBreathOutMessage(lastRoundDuration / 2);
                Console.WriteLine();
            }
            else
            {
                ShowBreathInMessage(roundDuration / 2);
                ShowBreathOutMessage(roundDuration / 2);
                Console.WriteLine();
            }
        }
        //display ending message and return to the menu
        base.DisplayEndingMessage();

    }

    private void ShowBreathInMessage(int duration){
        Console.Write("Breath in...");
        base.ShowCountDownTimer(duration);
        Console.WriteLine();
    }

    private void ShowBreathOutMessage(int duration){
        Console.Write("Breath out...");
        base.ShowCountDownTimer(duration);
        Console.WriteLine();
    }
}