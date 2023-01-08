using System;

class Program
{
    static void Main(string[] args)
    {
        //Create list
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished");
            string userList = Console.ReadLine();
            userNumber = int.Parse(userList);

            if (userNumber != 0 )
            {
                numbers.Add(userNumber);
            }
        }

        //Compute sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Compute average
        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}");
        //Find Max
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

    }
}