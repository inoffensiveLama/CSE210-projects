public class Menu{
        
        //Menu variables
        public int _choice = 0;


        public Menu()
        {

        }
        //methods
        public void DisplayMenu(){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
        }

        public void UpdateUserChoice(){
            _choice = int.Parse(Console.ReadLine());
        }

        /*
        
        */
}