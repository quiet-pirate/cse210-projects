using System.IO;

public class Goals
{
    public string _goalName = "";
    public string _goalDescription = "";
    public int _points = 0;
    public bool _complete;

    public string GetName()
    {
        return _goalName;
    }
    public void SetName(string goalName)
    {
        _goalName = goalName;
    }
    public RecordEvent()
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

    public int GetPoints()
    {
        //adds _points
        return 
    }
    //ShowList()
    //AddScore()
    DisplayScore()
    {
        //total points
    }
}