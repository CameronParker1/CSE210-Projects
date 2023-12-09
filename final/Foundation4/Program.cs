using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("09 December 2023", 45, 4);
        activities.Add(running);

        Cycling cycling = new Cycling("08 December 2023", 65, 18);
        activities.Add(cycling);

        Swimming swimming = new Swimming("07 December 2023", 30, 25);
        activities.Add(swimming);

        foreach (Activity exercise in activities)
        {
            exercise.GetSummary();
        }

    }
}