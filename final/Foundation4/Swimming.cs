using System;
class Swimming: Activity
{
    private int _laps = 0;

    public Swimming(string date, double lenghtActivity, int laps) : base (date, lenghtActivity)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 /1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance()/_lengthActivity)*60 ;
    }
    public override double GetPace()
    {
        return (_lengthActivity/GetDistance());
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date}-Swimming,-{_lengthActivity} minutes-{GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}