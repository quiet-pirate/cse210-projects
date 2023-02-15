using System;
public class Reception : Event
{
    public string _reservationEmail = "";

    public Reception() : base()
    {
        return "";
    }

    public void ReservationDone()
    {
        Console.Write($"Attendee E-mail: {_reservationEmail}");
    }
}