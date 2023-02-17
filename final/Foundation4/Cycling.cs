using System;
class Cycling: Activity
{
    private double _speed = 0;
    private double _distance = 0;
    public Cycling (string date, double _distance, double lengthActivity, double speed) : base (date, lengthActivity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/_lengthActivity)*60 ;
    }
    public override double GetPace()
    {
        return (_lengthActivity/_distance) ;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date}-Cycling,-{_lengthActivity} minutes-{GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}