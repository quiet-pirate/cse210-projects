using System;
public class Comments
{
    public string _commentAuthor = "";
    public string _comment = "";
    
    
    //comments.Add"
    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commentAuthor}");
        Console.WriteLine($"Comment:{_comment}");
    }

    
}