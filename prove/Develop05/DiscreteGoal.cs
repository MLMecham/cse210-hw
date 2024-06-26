using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class DiscreteGoal : Goal
{
    bool _completed;
    int _pointsWorth;

    public DiscreteGoal(bool completed, int pointsWorth, string name, string description) : base(name, description)
    {
        _completed = completed;
        _pointsWorth = pointsWorth;
    }

    public override int CalculateScore()
    {
        if (_completed == true)
        {
            return _pointsWorth;
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
            Console.WriteLine("\nHave you completed this goal?");
            Console.Write("(Enter Y or N):  ");
            string answer = Console.ReadLine();

        
            if (answer.ToLower() == "y")
            {
                _completed = true;
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Congradulations for completing your goal.");
                Console.WriteLine($"You have earned {_pointsWorth} points!");

                Console.Write("\nHit enter to continue: ");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Continue working hard to complete this goal.");

                Console.Write("Hit enter to continue: ");
                Console.ReadLine();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("You have already completed this goal");
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
            Console.WriteLine($"[ ] {_name} ({_description})");
        }

    
    }

    public override string ToString()
    {
        return String.Join(",", "1", _completed, _pointsWorth, _name, _description);
    }
}
