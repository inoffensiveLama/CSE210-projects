using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new RunningActivity("03 Nov 2022", 30, 5000),
            new CyclingActivity("04 Nov 2022", 45, 20),
            new SwimmingActivity("05 Nov 2022", 60, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}