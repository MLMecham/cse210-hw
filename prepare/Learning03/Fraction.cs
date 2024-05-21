public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholenumnber)
    {
        _top = wholenumnber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

     public void SetTop(int topNumber)
    {
        _top = topNumber;
    }

    public int GetBottom()
    {
        return _bottom;
    }

     public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string stringTop = _top.ToString();
        string stringBottom = _bottom.ToString();

        return stringTop + "/" + stringBottom;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;

        return decimalValue;
    }
}