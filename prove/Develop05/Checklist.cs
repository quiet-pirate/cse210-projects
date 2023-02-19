using System;

public abstract class Checklist : Goals
{
    //# times
    //1-each time get points
    //2- complete get bonus points
    private int _bonus = 0;
    public int _performedCount = 0;

    public Checklist(string goalName, string goalDescription, int bonus): base(goalName, goalDescription)
    {
        _bonus = bonus;
    }
    public int AddBonus()
    {
        return base.AddPoints()+_bonus;
    }
    public int Performed()
    {
        return _performedCount;
    }
    public override string ToString()
    {
        return "";
    }
}