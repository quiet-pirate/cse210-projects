using System;
abstract class Activity
{
    private string _date;
    private double _lenghtActivity;

    public Activity()
    {

    }
    public abstract double GetDistance();

    public abstract double GetSpeed();
   
    public abstract double GetPace();
   
    public abstract void GetSummary();
}