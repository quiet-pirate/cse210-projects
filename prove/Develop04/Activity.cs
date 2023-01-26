using System;

public class Activity
{
    private int _counter;
    private int _duration;

    public void Timer()
    {
        for (var i = 0; i <10; i++)
        {
            Turn();

        }
    }

    public void dispayCountDown(int numSecondsToRun)
    {
        for (int i = 1; i <= numSecondsToRun; i++)
        {
            Console.Write(string.Format("You may begin in {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}