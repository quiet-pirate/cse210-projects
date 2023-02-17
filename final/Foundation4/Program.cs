using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> newActivity = new List<Activity>();

        Swimming a1 = new Swimming("Feb 14", 65, 10);
        newActivity.Add(a1);

        Cycling a2 =  new Cycling("Feb 15", 9, 15, 20);
        newActivity.Add(a2);

        Running a3 = new Running("Feb 16", 2, 30.00);
        newActivity.Add(a3);

        foreach (Activity item in newActivity)
        {
            item.GetSummary();
        }
        

    }
}