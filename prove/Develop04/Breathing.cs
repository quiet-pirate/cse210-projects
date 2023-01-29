using System;

public class Breathing : Activity
{
    string _inMessage = "";
    string _outMessage = "";

 public void RunBreathing()
 {
    Console.WriteLine("Breathing Activity");
    //Display start message
    //Display description "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    //BreathingExercise()
 }
public void BreathingExercise()
{
    //loop until number of seconds specified
    Console.WriteLine("Breathe In");
    //pause
    //show countdown
    Console.WriteLine("Breathe Out");

}

}