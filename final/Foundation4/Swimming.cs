public class Swimming : Activity
{
    private double _numberOfLaps;


    public Swimming(double numberOfLaps, double duration, int year, int month, int day) : base(duration, year, month, day)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()}");
        Console.Write($" Swimming");
        Console.Write($" ({_duration} min)-");
        Console.Write($"Distance {CalculateDistance()} miles,");
        Console.Write($" Speed {CalculateSpeed()} mph,");
        Console.WriteLine($" Pace: {CalculatePace()} min per mile");
        
    }
    public override double CalculateDistance()
    {
        return Math.Round(_numberOfLaps * 50 / 1000 * .62, 1);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(CalculateDistance() / _duration * 60, 1);
    }

    public override double CalculatePace()
    {
        return Math.Round(_duration / CalculateDistance(), 1);
    }
}