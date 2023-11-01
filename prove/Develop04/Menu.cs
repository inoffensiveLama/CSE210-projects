public class Menu{
    //Attributes
    private List<string> _DESCRIPTIONS = new List<string>{
        "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };
    private List<string> _NAMES = new List<string>{
        "Breathing Activity",
        "Reflecting Activity",
        "Listing Activity"
    };

    //Constructor
    public Menu(){

    }

    //Mehtods
    public void Run(){
        int userChoice = 0;
        do{
            Console.Clear();
            Console.WriteLine("Menu Options:");
            for(int i = 1; i <= _NAMES.Count; i++){
                Console.WriteLine($" {i}. Start {_NAMES[i-1]}");
            }
            Console.WriteLine(" 4. Quit");
            userChoice = int.Parse(Console.ReadLine());

            switch(userChoice){
                case 1:
                    BreathingActivity BreathingActivity = new BreathingActivity(_NAMES[userChoice - 1], _DESCRIPTIONS[userChoice - 1]);
                    BreathingActivity.Run();
                    break;
                case 2 :
                    ReflectingActivity ReflectingActivity = new ReflectingActivity(_NAMES[userChoice - 1], _DESCRIPTIONS[userChoice - 1]);
                    ReflectingActivity.Run();
                    break;
                case 3 :
                    ListActivity ListActivity = new ListActivity(_NAMES[userChoice - 1], _DESCRIPTIONS[userChoice - 1]);
                    ListActivity.Run();
                    break;
                case 4 :
                    break;
            }
        }while(userChoice != 4);
        
    }
}