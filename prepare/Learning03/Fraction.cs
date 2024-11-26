public class Fraction
{
    // declare variables 
    private int _top;
    private int _bottom;

    // below are three constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Add setters and getters for top and bottom
    public int GetTop()
    {
        return _top;
    } 

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    } 

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // create methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    // display result
    public void Display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
}