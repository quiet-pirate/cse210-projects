using System;

public class Checklist : Goals
{
    //# times
    //1-each time get points
    //2- complete get bonus points
    public int _bonus = 0;
    public int _performedCount = 0;

    public void ChecklistGoal()
    {

    }
    public int AddBonus(): base()
    {
        return base.AddPoints()+_bonus;
    }
    public int Performed()
    {
        return _performedCount;
    }
}