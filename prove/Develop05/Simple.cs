using System;

public class Simple : Goals
{
    //end if you do the tast you get points
    private int goalType = 1;
    private bool _goalComplete;

    public SimpleGoal()
    {

    }
    public SimpleGoal(string goalName, string goalDescription, int points, bool complete) : base(goalName, goalDescription, points)
    {
        _goalComplete = goalComplete;
    }
    public override string ToString()
    {
        return string.Format("[{0}] {1} {2}", ((_goalComplete == false)?)"":"x"),
        getGoalName(), getGoaDescription();
    }
    public override void RecordEvent()
    {
        Console.WriteLine(string.Format($"Congratulations! You have earned {GetPoints()}"));
        _goalComplete = true;
    }
    
}