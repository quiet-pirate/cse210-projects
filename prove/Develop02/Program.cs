using System;

namespace Developer02{
    public class Program
    {
        static void Main()
        {
            Journal journal = new Journal();
            int _choice = 0;
            // Console.WriteLine(@"Please choose what you would like to do:
            // 1.Write
            // 2.Display
            // 3.Load File
            // 4.Save 
            // 5.Quit
            // 6.Add Photo");
            // _choice = int.Parse(Console.ReadLine());

            while (_choice != 5)
            {
                Console.WriteLine(@"Please choose what you would like to do:
                1.Write
                2.Display
                3.Load File
                4.Save 
                5.Quit
                6.Add Photo");
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
}

