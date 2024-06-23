public class MultiStepGoal : Goal
{
    bool _completed;
    int _pointsPerStep;
    int _pointsPerCompletion;
    int _targetNumber;
    int _progressNumber;

    public MultiStepGoal(bool completed, int points, int bonus, int target, int progress, string name, string description) : base(name, description)
    {
        _completed = completed;
        _pointsPerStep = points;
        _pointsPerCompletion = bonus;
        _targetNumber = target;
        _progressNumber = progress;

    }

    public override int CalculateScore()
    {
        if (_completed == true)
        {
            return _pointsPerCompletion + (_pointsPerStep * _progressNumber);
        }
        else
        {
            return _pointsPerStep * _progressNumber;
        }
    }
    public override void UpdateGoal()
    {
        Console.WriteLine(_description);
        Console.WriteLine("Have you completed this goal?");
        Console.Write("(Enter Y or N):  ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "y")
        {
            
            _progressNumber++;
            Console.WriteLine("Congradulations for making progress on your goal!.");
            Console.WriteLine($"You have earned {_pointsPerStep} points!");

            Console.Write("\nHit enter to continue: ");
            Console.ReadLine();

            if (_progressNumber == _targetNumber)
            {
                _completed = true;
                Console.WriteLine("\nWell Done! You have reached your goal!");
                Console.WriteLine($"For your perserverance you have earned an additional {_pointsPerCompletion} points!");
                Console.WriteLine("You may continue to complete this goal for more points, but there won't be another bonus.");

                Console.Write("\nHit enter to continue: ");
                Console.ReadLine();
            }

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
        if (_completed == true)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently Completed: {_progressNumber}/{_targetNumber}");
        }
    }
}