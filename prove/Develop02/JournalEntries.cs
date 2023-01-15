using System;

namespace Developer02{

    public class JournalEntries
    {
        public string _date = "";
        public string _prompt = "";
        public string _response = "";

        public void UserDate()
        {
            Console.WriteLine("Date:");
            _date = Console.ReadLine();
            Console.WriteLine($"Entry Date: {_date}");
        }
        public string ProvidePrompt()
        {
            Random rnd = new Random();  
            List<string> questions = new List<string>();
            questions.Add("Who was the most interesting person I interacted with today?");
            questions.Add("What was the best part of my day?");
            questions.Add("How did I see the hand of the Lord in my life today?");
            questions.Add("What was the strongest emotion I felt today?");
            questions.Add("If I had one thing I could do over today, what would it be?");

            int index = rnd.Next(0,4);
            return questions[index];

        }
        public void EnterJournal()
        {
            Console.WriteLine("Enter your response here:");
            _response = Console.ReadLine();
            Console.WriteLine($"{_response}");
        }

    }
}

