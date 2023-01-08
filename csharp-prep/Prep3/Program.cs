using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);

        int guess = -1;

        //Console.Write("What is the magic number?");
        //int number = Console.ReadLine();

        while (guess != number)
         {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

        
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }

         }
        
       
    }
}