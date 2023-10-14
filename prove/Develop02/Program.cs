using System;

class Program
{
    static void Main(string[] args)
    {
        Menu Menu = new Menu();
        Journal Journal = new Journal();
        Prompt Prompt = new Prompt();

        do{
        
        Menu.DisplayMenu();

        do{
            Menu.UpdateUserChoice();
            string filename = "";

            switch (Menu._choice) {
            case 1:
            //Write into the journal
                Entry entry = new Entry();
                string prompt = Prompt.GetPrompt();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{prompt}");
                Console.Write(">");
                string response = Console.ReadLine();
                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;
                Journal.addEntry(entry);
            break;
            case 2:
            //Display the journal
                Journal.display();
            break;
            case 3:
            //load the journal
                Console.Write("What is the filename? ");
                filename = Console.ReadLine();
                Journal.load(filename);
            break;
            case 4:
            //save the journal
                Console.Write("What is the filename? ");
                filename = Console.ReadLine();
                Journal.save(filename);
            break;
            default:
            //Quit
            break;
            
        }

        }while((Menu._choice > 5) || (Menu._choice < 1));


        
        }while(Menu._choice != 5);
        
    }
}