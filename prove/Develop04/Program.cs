using System;

public class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        int _choice = 0 ;
        while (_choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(@"
            1.Start breathing activity
            2.Start reflecting activity
            3.Start listing activity
            4.Quit
            Select a choice from the menu");
            _choice = int.Parse(Console.ReadLine());

            if(_choice == 1)
            {
                //activity.BreathingExercise();
                activity.RunActivity();
            }
            if(_choice == 2)
            {
                activity.RunActivity();
            }
        }

    }
}