using System;

namespace Developer02{
    public class Program
    {
        static void Main()
        {
            Journal journal = new Journal();
            int _choice = 0;
            Console.WriteLine("Please choose what you would like to do:\n 1.Write\n 2.Display\n 3.Load File\n 4.Save\n 5.Quit\n 6.Add Photo");
            _choice = int.Parse(Console.ReadLine());

            if(_choice == 1)
            {
                journal.WriteEntry();
            }
            if(_choice == 2)
            {
                 journal.Display();
            }
            if(_choice == 3)
            {
                journal.LoadFile();
            }
            if(_choice == 4)
            {
                journal.SaveFile();
            }
            if(_choice == 5)
            {
                journal.Quit();
            }
            if(_choice == 6)
            {
                journal.Photo();
            }
        }
    }
}

