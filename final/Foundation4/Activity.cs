using System;
abstract class Activity
{
    private string _date;
    private double _lengthActivity;

    public Activity(string date, double lengthActivity)
    {
        _date = date;
        _lengthActivity = lengthActivity;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();
   
    public abstract double GetPace();
   
    public abstract void GetSummary();
}