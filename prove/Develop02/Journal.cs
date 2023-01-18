using System.IO;

namespace Developer02
{

    public class Journal
    {
        public List<string> list = new List<string>();
        public int _choice = 0;
        //string response = "";
        JournalEntries journalEntries = new JournalEntries();
        public void WriteEntry()
        {
            Console.Write("Write here:");
            journalEntries.UserDate();
            journalEntries.ProvidePrompt();
            journalEntries.EnterJournal();
            
        }
        public void Display()
        {
            string[] entries = {};
            foreach (string entry in entries)
            {
            Console.WriteLine($"Date: {journalEntries._date}, {journalEntries._prompt}, {journalEntries._response}");
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
                save.Write($"Date:{journalEntries._date},\n {journalEntries._prompt},\n {journalEntries._response}");
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
