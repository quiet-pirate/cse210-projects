using System;
class Swimming: Activity
{
    private int _laps = 0;

    public Swimming()
    {

    }
    public override double GetDistance()
    {
        return _laps * 50 /1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return 0 ;
    }
    public override double GetPace()
    {
        return 0 ;//override
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{date}");
    }
}