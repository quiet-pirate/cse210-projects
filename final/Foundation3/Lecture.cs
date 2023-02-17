using System;
public class Lecture : Event
{
    private string _speaker = "";
    private int _limitedCapacity = 0;

    public Lecture (string eventTitle, string description, string date, string time, string address,string eventType, string speaker, int limitedCapacity) : base (eventTitle, description, date, time, address, eventType)
    {
        _limitedCapacity = limitedCapacity;
        eventTitle = "Lecture";
        description = "Speaker with audience";
        eventType = "Lecture";
    }
    public void GetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int FullCapacity()
    {
        return _limitedCapacity;
    } 
}