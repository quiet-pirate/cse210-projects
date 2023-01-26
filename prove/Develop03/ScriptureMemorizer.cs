using System;


class ScriptureMemorizer
{
    private Scripture _scripture;
    private List<string> scriptureTextWordList;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
        scriptureTextWordList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextWordList = _scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromList()
    {
        //clear console
        int numWordsToRemove = new Random().Next(3);
        int wordsRemoved = 0;

        do {
            int rndIndex = new Random().Next(0,scriptureTextWordList.Count());
            if (scriptureTextWordList[rndIndex].Contains(' ') == false)
            {
            scriptureTextWordList[rndIndex] = new string('_',scriptureTextWordList[rndIndex].Length);
            wordsRemoved++;
            }
            

        }while(wordsRemoved != numWordsToRemove);
    
    public string toString() 
    {
        return string.Join(' ', scriptureTextWordList);
    }

    public bool hasWordLeft()
    {
        bool retValue = false;

        foreach(string word in scriptureTextWordList)
        {
            if(word.Contains('_') == false)
            {
                retValue = true;
                break;
            }
            }
        }
    }
}