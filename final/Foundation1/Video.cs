using System;

public class Video
{
    public string _title = "";
    public string _author = "";

    public double _lenght = 0;
   
    public List<Comments> comments = new List<Comments>();
    
    public void Comments()
    {
        Comments entries = new Comments();
        entries.Comment();
        comments.Add(entries);
    }
    public void NumberOfComments()
    {
        foreach (Comments item in comments)
        {
            Console.WriteLine(comments.Count);
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Lenght in seconds : {_lenght}");
    }
}