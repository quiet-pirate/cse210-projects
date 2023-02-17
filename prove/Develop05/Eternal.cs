using System;

public class Eternal : Goals
{
    //never end
    //keep adding loop i+1
    private int _goalCount = 0;
    public Eternal (int goalCount) :base (goalCount)
    {
        _goalCount = goalCount;
    }

    public void EternalGoal()
    {
       // foreach?
    }
    public void GoalCountTotal()
    {
        //add points
        AddPoints();
    }

}