using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        Menu Menu = new Menu();

        int menuUserChoice = 0;
        

        do{
            Menu.DisplayMainMenu();

            do{
                Menu.UpdateUserChoice();
                menuUserChoice = Menu.GetUserChoice();
            }while(menuUserChoice < 1 || menuUserChoice > 6);
            

            switch(menuUserChoice){
                case 1: //creat new Goal
                    Menu.DisplayCreateNewGoalMenu();
                    int goalChoice = 0;
                    do{
                        goalChoice = int.Parse(Console.ReadLine());
                    }while (goalChoice < 1 || goalChoice > 3);

                    string name;
                    string description;
                    int points;
                    int bonusAmount;
                    int timesToComplete;
                    string fileName;
                    int i;

                    switch(goalChoice){
                        case 1: //simple goal
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case 2: //eternal goal
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            goals.Add(new EternalGoal(name, description, points));
                            break;
                        case 3: //checklist goal
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            timesToComplete = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            bonusAmount = int.Parse(Console.ReadLine());
                            goals.Add(new ChecklistGoal(name, description, points, bonusAmount, timesToComplete));
                            break;
                    }

                    break;
                case 2: //list goals
                    Console.WriteLine("The goals are:");
                    foreach(Goal goal in goals){
                        Console.WriteLine(goal.ToString());
                    }
                    break;
                case 3: //save goals
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine($"{Menu.GetScore()}");
                        foreach(Goal goal in goals){
                        outputFile.WriteLine(goal.ToSavedString());
                    }
                    }
                    break;
                case 4: //load goals
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    i = 1;
                    foreach (string line in lines)
                    {
                        if (i == 1){
                            Menu.SetScore(int.Parse(line));
                        }else{
                            string[] parts = line.Split(',', ':');

                            string goalType = parts[0];
                            string goalName = parts[1];
                            string goalDescription = parts[2];
                            int goalPoints = int.Parse(parts[3]);
                            bool goalCompletion;
                            int goalBonusAmount;
                            int goalNumberToCompletion;
                            int goalNumberCompleted;

                            switch (goalType){
                                case "SimpleGoal":
                                    goalCompletion = bool.Parse(parts[4]);
                                    goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, goalCompletion));
                                    break;
                                case "EternalGoal":
                                    goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                                    break;
                                case "ChecklistGoal":
                                    goalCompletion = bool.Parse(parts[4]);
                                    goalBonusAmount = int.Parse(parts[5]);
                                    goalNumberToCompletion = int.Parse(parts[6]);
                                    goalNumberCompleted = int.Parse(parts[7]);
                                    goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalCompletion, goalBonusAmount, goalNumberToCompletion, goalNumberCompleted));
                                    break;
                            }
                        }
                        i++;
                        
                    }
                    break;
                case 5: //record event
                    Console.WriteLine("The goals are:");
                    i = 1;
                    foreach(Goal goal in goals){
                        Console.WriteLine($"{i}. {goal.GetName()}");
                        i++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int choice = 0;
                    choice = int.Parse(Console.ReadLine());
                    int previousScore = Menu.GetScore();
                    Menu.SetScore(previousScore + goals[choice-1].RecordEvent());
                    int currentScore = Menu.GetScore();
                    Console.WriteLine($"Congratulations! You have earned {currentScore-previousScore} points");
                    Console.WriteLine($"You now have {Menu.GetScore()} points");
                    break;
                case 6: //quit the program
                    break;
            }
        }while (menuUserChoice != 6);
        
    }
}