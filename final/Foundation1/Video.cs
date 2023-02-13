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
        entries.DisplayComment();
        comments.Add(entries);

        
       Comments c1 = new Comments();
       c1._comment = "That was fun to watch";
       c1._commentAuthor = "Mr. Smith";
       
       Comments c2 = new Comments();
       c2._commentAuthor = "Chuchita";
       c2._comment = "Cool beans";
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