public class Menu{
        
        //Menu variables
        public int _choice = 0;


        public Menu()
        {

        }
        //methods
        public void DisplayMenu(){
            //displays the menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

        }

        public void UpdateUserChoice(){
            //asks the user for a number and saves it to the variable choice
            Console.Write("What would you like to do?");
            _choice = int.Parse(Console.ReadLine());
        }
}