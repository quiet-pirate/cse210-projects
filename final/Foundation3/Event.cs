using System;
public class Event
{
    protected string _eventTitle = "";
    protected string _description = "";
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    public Event(string eventTitle, string description, string date, string time, string address, string eventType)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }
    public string GetTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public new string GetType()
    {
        return _eventType;
    }
    public void Standard()
    {
        Console.WriteLine($"{GetTitle()}, {GetDescription()}, Date: {_date}, Time: {_time}, Address: {_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"{GetTitle()}, {GetDescription()}, Date:{_date}, Time: {_time}, Address:{_address}");
        Console.WriteLine($"{GetType()}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{GetType()}, {GetTitle()}, {GetDate()}");
    }
}