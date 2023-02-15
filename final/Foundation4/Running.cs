using System;
class Running : Activity
{
    private double _distance = 0;

    public Running (double distance): base(date, lengthActivity)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return 0;
    }
    public override double GetSpeed()
    {
        return 0;
    }
    public override double GetPace()
    {
        return 0 ;
    }
    public override void GetSummary()
    {
        Console.WriteLine("The Summary");
    }
}