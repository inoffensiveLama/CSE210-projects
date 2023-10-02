using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Menu Menu = new Menu();
        Journal Journal = new Journal();
        do{
        
        Menu.DisplayMenu();
        Menu.UpdateUserChoice();
        switch (Menu._choice) {
            case 1:
            //Write into the journal
                Journal.WriteJournal();
            break;
            case 2:
            //Display the journal
                Journal.DisplayJournal();
            break;
            case 3:
            //load the journal
                Journal.LoadJournal();
            break;
            case 4:
            //save the journal
                Journal.SaveJournal();
            break;
            default:
            //Quit
            break;
        }
        }while(Menu._choice != 5);
        
    }
}