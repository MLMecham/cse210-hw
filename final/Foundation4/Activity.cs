public class Activity
{
    protected DateTime _dateTime;

    protected double _duration;

    public Activity(double duration, int year, int month, int day)
    {
        _duration = duration;
        _dateTime = new(year, month, day);
    }

    
    public virtual void GetSummary()
    {

    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetDate()
    {
        return $"{_dateTime.ToString("dd MMM yyyy")}";
    }
}