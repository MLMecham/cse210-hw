public class Cycling : Activity
{
    private double _speed;


    public Cycling(double speed, double duration, int year, int month, int day) : base(duration, year, month, day)
    {
        _speed = speed;
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()}");
        Console.Write($" Cycling");
        Console.Write($" ({_duration} min)-");
        Console.Write($"Distance {CalculateDistance()} miles,");
        Console.Write($" Speed {_speed} mph,");
        Console.WriteLine($" Pace: {CalculatePace()} min per mile");
        
    }
    public override double CalculateDistance()
    {
        return Math.Round(_speed * _duration / 60, 1);
    }

    public override double CalculatePace()
    {
        return Math.Round(_duration / CalculateDistance(), 1);
    }
}