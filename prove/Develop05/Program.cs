using System;

class Program
{
    static void Main(string[] args)
    {
        Goal CompletableGoal = new ChecklistGoal("name", "descr", 50, 111, 1, 40);
        Console.WriteLine(CompletableGoal);
    }
}