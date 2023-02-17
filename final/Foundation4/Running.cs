using System;
class Running : Activity
{
    private double _distance = 0;

    public Running (string date, double distance, double lengthActivity): base (date, lengthActivity)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/_lengthActivity)*60;
    }
    public override double GetPace()
    {
        return (_lengthActivity/_distance) ;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date}-Running-{_lengthActivity} minutes-{GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}