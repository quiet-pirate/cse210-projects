using System;
public class Event
{
    public string _eventTitle = "";
    public string _description = "";
    public string _date;
    public string _time;
    public string _address;

    public void Standard()
    {
        Console.WriteLine("Standard Message");
    }

    public void FullDetails()
    {
        Console.WriteLine("Full Details Message");
    }
    public void ShortDescription()
    {
        Console.WriteLine("Short Description");
    }
}