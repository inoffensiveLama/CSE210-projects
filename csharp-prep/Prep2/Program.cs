using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentageString = Console.ReadLine();
        string gradeLetter = "something went wrong";
        int gradePercentage = int.Parse(gradePercentageString);
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine(gradeLetter);

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations. You passed the class!");
        }
        else 
        {
            Console.WriteLine("you didnt pass. try harder next time.");
        }
    }
}