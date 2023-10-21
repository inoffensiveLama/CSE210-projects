using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture Scripture = new Scripture();
        Scripture.LoadScripture();
        string userChoice = "";

        do{
            //clear the console
            Console.Clear();

            //display the scripture with the words blacked out (the first time there arent any words missing)
            Console.WriteLine(Scripture.GetScripture());

            //asking the user if they want to continue
            Console.WriteLine("Press enter to continue and type \"quit\" to close the program");
            userChoice = Console.ReadLine();

            //black out one random word and update the number of blackedout words
            Scripture.BlackOutRandomWord();

            Scripture.CountBlackedOutWords();

        }while((Scripture.GetNumberOfBlackedOutWords() < Scripture.GetNumberOfWords()) && (userChoice != "quit"));

        
    }
}