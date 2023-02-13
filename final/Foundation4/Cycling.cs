using System;
class Cycling: Activity
{
    private double _speed = 0;
    public Cycling()
    {

    }

    public override double GetDistance()
    {
        return 0 ;//override
    }
    public override double GetSpeed()
    {
        return 0 ;//override
    }
    public override double GetPace()
    {
        return 0 ;//override
    }
    public override void GetSummary()
    {
        Console.WriteLine("The Summary");
    }
}