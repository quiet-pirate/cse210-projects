using System;
namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment("Alejandra", "Ocean Life");
            // assignment1.SetName("Bradford");
            // assignment1.SetTopic("Ocean Life");
            Console.WriteLine(assignment1.GetSummary());

            MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());

            WriteAssignment assignment3 = new WriteAssignment("Mary Waters", "European History", "The Cause of World War II");
            Console.WriteLine(assignment3.GetSummary());
            Console.WriteLine(assignment3.GetWritingInformation());
        }  
    }
}