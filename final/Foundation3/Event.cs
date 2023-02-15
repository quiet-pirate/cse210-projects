using System;
public class Event
{
    private string _eventTitle = "";
    private string _description = "";
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void GetDate()
    {
        Console.WriteLine(DateTime.Now);
    }
    public void GetTime()
    {
        Console.WriteLine(DateTime.Now.TimeOfDay);
    }
    public void Standard()
    {
        Console.WriteLine($"{GetTitle()}, {GetDescription()}, Date: {_date}, Time: {_time}, Address: {_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine("Full Details");
    }
    public void ShortDescription()
    {
        Console.WriteLine("Short Description");
    }
}