using System.IO;

public abstract class Goals
{
    private string _goalName = "";
    private string _goalDescription = "";
    private int _points = 0;
    public int _totalPoints = 0;
    public bool _complete;

    public Goals(string goalName, string goalDescription)
    {
        
    }
    public string GetName()
    {
        return _goalName;
    }
    public void SetName(string goalName)
    {
        _goalName = goalName;
    }
    public abstract string RecordEvent();  
    public void IsComplete()
    {
        //foreach (bool b in new bool [] {false,true});
        while (_complete == true)
        {
            Console.WriteLine($"[x] {_goalName}");
        }
        while (_complete == false)
        {
            Console.WriteLine($"[] {_goalName}");
        }
    }

    public int AddPoints()
    {
        while (_complete == true);
        //adds _points
        return _totalPoints + _points;
    }
    
    public void DisplayScore()
    {
        Console.WriteLine(AddPoints());
    }

    public abstract string ToString();
}