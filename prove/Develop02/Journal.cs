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
        public void LoadFile()
        {
            //Prompt user for file name?
            string filename = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            using (StreamReader read = new StreamReader(filename))
            {
                Console.WriteLine(read.ReadToEnd());
            }

        }

        public void SaveFile()
        {
            string filename = "myFile.txt";
            using(StreamWriter save = new StreamWriter(filename))
            {
                save.Write($"Date:{list._date},\n {list._prompt},\n {list._response}");
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
