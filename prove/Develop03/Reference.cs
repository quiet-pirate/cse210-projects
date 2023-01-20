using System;

public class Reference
{
   private string _book;
   private int _chapter;
   private int _verseStart;
   private int _verseEnd;

   public Reference()
   {
    _book = "";
    _chapter = 0;
    _verseStart = 0;
    _verseEnd = 0;
   }
   public Reference(string book, int chapter, int verseStart)
   {
     _book = book;
    _chapter = chapter;
    _verseStart = verseStart;
   }

   public Reference (string book, int chapter, int verseStart, int verseEnd)
   {
     _book = book;
    _chapter = chapter;
    _verseStart = verseStart;
    _verseEnd = verseEnd;
   }

   public void makeReference()
   {
    Console.WriteLine($"{_book} {_chapter}: {_verseStart}-{_verseEnd}");
   }
    // public string toString
}