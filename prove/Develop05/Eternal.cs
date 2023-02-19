using System;

public class Eternal : Goals
{
    //never end
    //keep adding loop i+1
    private int _goalCount = 0;
    public Eternal (string goalName, string goalDescription, int goalCount) :base (goalName, goalDescription)
    {
        _goalCount = goalCount;
    }

    public void EternalGoal()
    {
       // foreach?
    }
    public void GoalCountTotal()
    {
        AddPoints();
    }
    
    public override string RecordEvent()
    {
        return "something";
    }
    public override string ToString()
    {
        return "nothing";
    }

}