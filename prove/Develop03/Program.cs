using System;

class Program
{
    static void Main(string[] args)
    {
        //initiate all the variables and instances of classes we need
        Reference Reference = new Reference();
        Scripture Scripture = new Scripture();
        Words Words = new Words();

        //call all the method that only need to be done once in the beginning of the program
        Scripture.LoadScripture();
        Words.SetNumberOfWords(Scripture.GetScripture());
        Reference.LoadReference();
        

        string userChoice = "";
        int numberBlackWords = 0;
        int numberWords = Words.GetNumberOfWords();

        //print out the scripture until the user types in quit or until all words are blacked out
        do{
            //clear the console
            Console.Clear();

            //display location of the scripture
            Reference.DisplayReference();

            //display the scripture with the words blacked out (the first time there arent any words missing)
            Console.WriteLine(Scripture.GetBlackedOutScripture(Words.getBlackedOutWordIndex()));

            //asking the user if they want to continue
            Console.WriteLine("Press enter to continue and type \"quit\" to close the program");
            userChoice = Console.ReadLine();

            //black out one random word and update the number of blackedout words
            Words.blackOutWord();
            numberBlackWords = Words.getNumberOfBlackedOutWords();

        }while((numberBlackWords <= numberWords) && (userChoice != "quit"));
    }
}