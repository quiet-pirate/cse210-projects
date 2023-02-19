using System;

public abstract class Simple : Goals
{
    //end if you do the task you get points
    private int goalType = 1;
    private bool _goalComplete;

    public Simple(string goalName, string goalDescription, int points, bool goalComplete) : base(goalName, goalDescription)
    {
        _goalComplete = goalComplete;
    }
    // public override string ToString()
    // {
    //     return string.Format("[{0}] {1} {2}", "((_goalComplete == false)?)":"x"),
    //     getGoalName(), getGoalDescription();
    // }
    // public override void RecordEvent()
    // {
    //     Console.WriteLine(string.Format($"Congratulations! You have earned {GetPoints()}"));
    //     _goalComplete = true;
    // }
    
}