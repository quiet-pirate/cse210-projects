using System;
public class Reception : Event
{
    public string _reservationEmail = "";

    public Reception(string eventTitle, string description,string date, string time, string address, string eventType, string reservationEmail) : base(eventTitle, description, date, time, address, eventType)
    {
        _reservationEmail = reservationEmail;
        eventTitle = "Reception";
        description = "Private event that includes food";
        eventType = "Reception";
    }

    public void ReservationDone()
    {
        Console.Write($"Attendee E-mail: {_reservationEmail}");
    }
    
}