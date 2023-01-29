using System;

public class Listing : Activity
{
    public string _listingPrompt = "";
    public string _responsePrompt = "";

    public void RunListing()
    {
        //Display start message
        //Display description "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        //Count down
        //ProvidePrompt()
    }

    //Call the parent class for Starting Message, Description
    public void ProvidePrompt()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strenghts of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        int index = rnd.Next(0,4);
        Console.WriteLine(prompts[index]);
        _listingPrompt = prompts[index];
    }
//countdown
    public void EnterResponse()
    {
        _responsePrompt = Console.ReadLine();
    }

    public int ListAndCount()
    {
        //Count method. Counts items in list
    }

    //Call parent class to display End Mesage
}