using System;
public class Outdoor : Event
{
    public string _weatherForecast = "";
    public Outdoor(string eventTitle, string description, string date, string time, string address,string eventType, string weatherForecast): base(eventTitle, description,date, time, address, eventType)
    {
        _weatherForecast = weatherForecast;
        eventTitle = "Outdoor";
        description = "Family friendly event, dependent on weather";
        _eventType = "Outdoor";
    }

    public void Forecaster()
    {
        Console.WriteLine($"{_weatherForecast}");
    }
    
}