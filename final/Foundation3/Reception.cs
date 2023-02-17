using System;
public class Reception : Event
{
    public string _reservationEmail = "";

    public Reception(string eventTitle, string description,string date, string time, string address, string reservationEmail) : base(eventTitle, description, date, time, address)
    {
        _reservationEmail = reservationEmail;
        eventTitle = "Reception";
        description = "Private event that includes food";
    }

    public void ReservationDone()
    {
        Console.Write($"Attendee E-mail: {_reservationEmail}");
    }
}