using System;
public class Menu
{
    int _userSelection = 0;
    public Menu(int userSelection)
    {
        _userSelection = userSelection;
    }
            
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {0} points");
        Console.WriteLine(@"Menu Options:
        1.Create New Goal
        2.List Goals
        3.Save Goals
        4.Load Goals
        5.Record Event
        6.Quit");
        Console.WriteLine("Select a choice from the menu:");
    }
    Menu menu = new Menu(userSelection);
    private static int userSelection;

    menu.DisplayMenu();
        
    while (userSelection != 6)
    {
        userSelection = int.Parse(Console.ReadLine());
        switch (userSelection)
            {
            case 1:
                Console.WriteLine(@"The types of Goals are:
                    1.Simple Goal
                    2.Eternal Goal
                    3.Checklist Goal");
                Console.Write("Which type of goal would you like to create?");
                break;
            case 2:
                RecordKeeping.DisplayGoals();
            break;

            case 3:
                RecordKeeping.SaveFile();
            break;

            case 4:
                RecordKeeping.LoadFile();
            break;

            case 5:
                // RecordKeeping.RecordEvent();
            break;

            case 6:
                Console.WriteLine("Goodbye!");
            break;

            default:
                Console.WriteLine("Invalid input. Please select a number from 1 to 6.");
            break;
            }
        
    }
}