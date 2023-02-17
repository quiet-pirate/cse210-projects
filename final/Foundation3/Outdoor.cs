using System;
public class Outdoor : Event
{
    public string _weatherForecast = "";
    public Outdoor(string eventTitle, string description, string date, string time, string address, string weatherForecast): base(eventTitle, date, description, time, address)
    {
        _weatherForecast = weatherForecast;
        eventTitle = "Outdoor";
        description = "Family friendly event, dependent on weather";
    }

    public void Forecaster()
    {
        Console.WriteLine($"{_weatherForecast}");
    }
}