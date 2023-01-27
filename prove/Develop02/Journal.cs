using System.IO;

namespace Developer02
{

    public class Journal
    {
        public List<JournalEntry> list = new List<JournalEntry>();
        // public int _choice = 0;
        //string response = "";
        // JournalEntry journalEntries = new JournalEntry();
        public void WriteEntry()
        {
            JournalEntry journalEntries = new JournalEntry();
            Console.Write("Write here:");
            journalEntries.UserDate();
            journalEntries.ProvidePrompt();
            journalEntries.EnterJournal();
            list.Add(journalEntries);
            
        }
        public void Display()
        {
            foreach (JournalEntry item in list)
            {
            Console.WriteLine($"Date: {item._date}, {item._prompt}, {item._response}");
            Console.WriteLine();
            }
        }
         public void SaveFile()
        {
            string filename = "myFile.txt";
            using(StreamWriter save = new StreamWriter(filename))
            foreach (JournalEntry item in list)
            {
                save.Write($"{item._date}|{item._prompt}|{item._response}|");
            }

        }
        public void LoadFile()
        {
            string filename = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            using (StreamReader read = new StreamReader(filename))
            foreach(string item in lines)
            {
                JournalEntry fullEntry = new JournalEntry();
                list.Add(fullEntry);
                List <string> allInfo = item.Split("|").ToList();

                fullEntry._date = allInfo[0];
                fullEntry._prompt = allInfo[1];
                fullEntry._response = allInfo[2];
                
            }

        }
        
        public void Quit()
        {
            Console.WriteLine("Thank you. Goodbye");
        }

        public void Photo()
        {
            Console.Write("Enter description of photo here:");
            string response = Console.ReadLine();
            string filename = "myPhotoFile.txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(response);
            }
        }
        }

    }
