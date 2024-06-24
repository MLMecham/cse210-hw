public abstract class Goal
{
    protected string _name;
    protected string _description;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract void DisplayGoal();
    public abstract void UpdateGoal();
    public abstract int CalculateScore();
    public abstract override string ToString();
}