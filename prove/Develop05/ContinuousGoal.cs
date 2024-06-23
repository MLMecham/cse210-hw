public class ContinuousGoal : Goal
{
    int _pointsPerCompletion;
    int _totalCompletions;

    public ContinuousGoal(int points, int completions, string name, string description) : base(name, description)
    {
        _pointsPerCompletion = points;
        _totalCompletions = completions;
    }

    public override int CalculateScore()
    {
        return _pointsPerCompletion * _totalCompletions;
    }
    public override void UpdateGoal()
    {
        Console.WriteLine(_description);
        Console.WriteLine("Have you completed this goal?");
        Console.Write("(Enter Y or N):  ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "y")
        {
            _totalCompletions += 1;
            Console.WriteLine("Congradulations for completing your goal.");
            Console.WriteLine($"You have earned {_pointsPerCompletion} points!");
            Console.WriteLine("We hope you continue to complete this goal!");

            Console.Write("\nHit enter to continue: ");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Continue working hard to complete this goal.");

            Console.Write("Hit enter to continue: ");
            Console.ReadLine();
        }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
}