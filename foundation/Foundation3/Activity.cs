public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance(); // Must be overridden in derived classes
    public abstract double GetSpeed();    // Must be overridden in derived classes
    public abstract double GetPace();     // Must be overridden in derived classes

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}