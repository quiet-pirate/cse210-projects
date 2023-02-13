using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> newActivity = new List<Activity>();
        Swimming a1 = new Swimming();
        newActivity.Add(a1);
        Cycling a2 =  new Cycling();
        newActivity.Add(a2);
        Running a3 = new Running();
        newActivity.Add(a3);

        foreach (Activity item in newActivity)
        {
            item.GetSummary();
        }
        

    }
}