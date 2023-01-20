using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference ref = new Reference();
        //Console.WriteLine(ref.MakeReference());
        
        // Reference ref1 = new Reference("Psalm", 27, 1, 2);
        // ref1.makeReference();


        Scripture scriptureReference = new Scripture(scriptureReference, "full text");
        Scripture scripture = new Scripture(scriptureReference,"text");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput;
        while (userInput != "quit" && scriptureMemorizer.hasWordLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromList();
        }
    }
}