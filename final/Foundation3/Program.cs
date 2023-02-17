using System;

class Program
{
    static void Main(string[] args)
    {
      

        List<Event> newEvent= new List<Event>();
        
        Lecture e1 = new Lecture("Understanding Your Limits","Presentation of new book", "April 23, 2023", "7:45 am","University Center. AZ","Lecture","Dr. Wilson", 45);
        newEvent.Add(e1);

        Reception e2 = new Reception("Adams & Johnson", "Wedding reception", "November 2, 2023", "1:45 p.m.", " 34 Paseo Dr. Hillsland, OH","Reception", "attendee@gmail.com");
        newEvent.Add(e2);

        Outdoor e3 = new Outdoor("SummerFest", "Arts and crafts fair", "June 21-24, 2023", "9am-7pm", "Cache County Fairgrounds", "Outdoor","Sunny");
        newEvent.Add(e3);

        foreach (Event item in newEvent)
        {
            item.Standard();
            item.FullDetails();
            item.ShortDescription();
        }
    }
}