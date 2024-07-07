public class Running : Activity
{
    private double _distance;


    public Running(double distance, double duration, int year, int month, int day) : base(duration, year, month, day)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()}");
        Console.Write($" Running");
        Console.Write($" ({_duration} min)-");
        Console.Write($"Distance {_distance} miles,");
        Console.Write($" Speed {CalculateSpeed()} mph,");
        Console.WriteLine($" Pace: {CalculatePace()} min per mile");
        
    }
    public override double CalculateSpeed()
    {
        return Math.Round(_distance / _duration * 60, 1);
    }

    public override double CalculatePace()
    {
        return Math.Round(_duration / _distance, 1);
    }
}