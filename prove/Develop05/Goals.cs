using System.IO;

public class Goals
{
    public string _goalName = "";
    public string _goalDescription = "";
    public int _points = 0;
    public int _totalPoints = 0;
    public bool _complete;

    public Goals())
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
    public abstract RecordEvent()
    {
        //
    }   
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
        //adds _points
        return 
    }
    //ShowList()
    //AddScore()
    public int DisplayScore()
    {
        Console.WriteLine({_totalPoints});
    }
}