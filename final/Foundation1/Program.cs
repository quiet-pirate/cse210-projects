using System;

class Program
{
    static void Main(string[] args)
    {
       //iterate through the list of videos and for each one, display
       //the title, author, lenght, number of comments, and list
       //out the comments for that video
       Video v1 = new Video();
       v1._title = "HOW TO DO A JIGSAW PUZZLE QUICKLY";
       v1._author = "Karen Puzzles";
       v1._lenght = 1792;
       v1.DisplayInfo();
       v1.NumberOfComments();
       v1.Comments();

       Comments c1v1 = new Comments();
       c1v1._comment = "I use paper plates to sort colors";
       c1v1._commentAuthor = "MeSoCal01";
       Comments c2v1 = new Comments();
       c2v1._comment="My daughter likes to help with the last piece";
       c2v1._commentAuthor="KittyMom";
       Comments c3v1 = new Comments();
       c3v1._comment = "I love those colors of the cranes";
       c3v1._commentAuthor = "JigSaw Cray";

       v1.comments.Add(c1v1);
       v1.comments.Add(c2v1);
       v1.comments.Add(c3v1);

       Video v2 = new Video();
       v2._title = "One two three";
       v2._author = "Plain White Tees";
       v2._lenght = 180;
       v2.DisplayInfo();
       v2.NumberOfComments();
       v2.Comments();

       Video v3 = new Video();
       v3._title = "The Biggest MYTH About Your Things";
       v3._author = "The Minimal Mom";
       v3._lenght = 884;
       v3.DisplayInfo();
       v3.NumberOfComments();
       v3.Comments();
    

    }
}