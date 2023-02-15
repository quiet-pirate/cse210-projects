using System;
public class Lecture : Event
{
    private string _speaker = "";
    private int _limitedCapacity = 0;

    public Lecture (string speaker, string limitedCapacity) : base(eventTitle)
    {

    }
    public void GetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void FullCapacity()
    {
        //return?
    }
}