using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2.Display();

        Resume firstResume = new Resume();
        firstResume._name = "Name";

        firstResume._jobs.Add(job1);
        firstResume._jobs.Add(job2);

        firstResume.Display();
    }
   
    
}