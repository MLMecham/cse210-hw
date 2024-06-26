public class BadDiscreteGoal : Goal
{
    bool _completed;
    int _pointsWorth;

    public BadDiscreteGoal(bool completed, int pointsWorth, string name, string description) : base(name, description)
    {
        _completed = completed;
        _pointsWorth = pointsWorth;
    }

    public override int CalculateScore()
    {
        if (_completed == true)
        {
            return _pointsWorth * -1;
        }
        else
        {
            return 0;
        }
    }
    public override void UpdateGoal()
    {
        if (_completed == false)
        {
            Console.WriteLine(_description);
            Console.WriteLine("Have you completed this goal?");
            Console.Write("(Enter Y or N):  ");
            string answer = Console.ReadLine();

        
            if (answer.ToLower() == "y")
            {
                _completed = true;
                Console.WriteLine("Oh no!");
                Console.WriteLine($"You lost {_pointsWorth} points!");
                Console.WriteLine("Don't worry, the road to success is not a paved road. The way is rocky. Keep trying!");

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
        else
        {
            Console.WriteLine("You have already completed this goal");
            Console.Write("Hit enter to continue: ");
            Console.ReadLine();
        }
    }

    public override void DisplayGoal()
    {
        if (_completed == true)
        {
            Console.WriteLine($"[:c] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }

    
    }

    public override string ToString()
    {
        return String.Join(",", "4", _completed, _pointsWorth, _name, _description);
    }
}