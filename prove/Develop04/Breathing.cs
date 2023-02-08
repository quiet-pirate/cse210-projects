using System;

public class Breathing : Activity
{
    string _inMessage = "";
    string _outMessage = "";

public void RunBreathing(string inMessage, string outMessage) : base(nameActivity, description)
{
    Console.WriteLine("Breathing Activity");
    //Display start message
    Activity.StartingMessage("Breathing", "This activity will help you relax by walking through breathing in and out");
    //Display description "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    //BreathingExercise()
}

 
public void BreathingExercise(): base(numSecondsToRun)
{
    //loop until number of seconds specified
    Console.WriteLine("Breathe In");
    //pause
    //show countdown
    Activity.CountDown(int numSecondsToRun);
    Console.WriteLine("Breathe Out");

}

}