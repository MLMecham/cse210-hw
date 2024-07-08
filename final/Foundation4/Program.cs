using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        // Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new();

        Running running1 = new(5.0, 60, 2024, 7, 6);
        activities.Add(running1);
        // running1.GetSummary();

        Cycling cycling1 = new(12.0, 30, 2024, 7, 7);
        activities.Add(cycling1);
        // cycling1.GetSummary();

        Swimming swimming1 = new(40, 20, 2024, 7, 8);
        activities.Add(swimming1);

        // Console.WriteLine(swimming1.CalculateDistance());

        Console.WriteLine("Person A's Stats:\n");
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
        Console.WriteLine("\n");
    }
}