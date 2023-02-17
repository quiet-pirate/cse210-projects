using System;
abstract class Activity
{
    protected string _date;
    protected double _lengthActivity;


    public Activity(string date, double lengthActivity)
    {
        _date = date;
        _lengthActivity = lengthActivity;
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();
   
    public abstract double GetPace();
   
    public abstract void GetSummary();
}