using System;

class Scripture
{
   //private string _reference;
   //keeps track of scripture
   private string _scriptureText;

   private Reference _scriptureReference;
   public Scripture(Reference scriptureReference, string scriptureText)
   {
    _scriptureReference = scriptureReference;
    _scriptureText = scriptureText;
   }
   public string toString()
   {
    // return string.Format("{1} - {0}", _scriptureText, Reference, name);
    return $"{_scriptureText}";
   }

   //string text = System.IO.File.ReadAllText(@"C:\CSE210\cse210-projects\prove\Develop03\scriptures.txt");

    //System.Console.WriteLine($"scriptures.txt = {text}");
        //get index 3 and have it relate to _scriptureText
    
    //CREATIVITY SECTION!
    //var scripture = new Dictionary<string, int>();
    // using var reader = new TextFieldParser("scriptures.txt");
    // reader.TextFieldType = FieldType.Delimited;
    // reader.SetDelimiters(",");
    // reader.ReadField();
    // while(!reader.EndofData)
    // {
    //     var fields = reader.ReadFields();
    //     var scripture = fields[3];
    //     var chapter = fields[1];
    // }

}