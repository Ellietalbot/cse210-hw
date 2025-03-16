using System;

class Program
{
    private static bool running = true;
    private static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        while (running)
        {
            DisplayMenu();
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine($"\nTotal Points: {goalManager.GetTotalPoints()}");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Exit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int menuChoice))
        {
            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    CreateGoal();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    goalManager.DisplayGoals();
                    
                    break;

                case 3:
                    Console.Clear();
                    goalManager.SaveGoals();
                    
                    break;

                case 4:
                    Console.Clear();
                    goalManager.LoadGoals();
                    
                    break;

                case 5:
                    Console.Clear();
                    goalManager.RecordGoalEvent(); 
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    running = false;
                    
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid menu choice.");
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        if (int.TryParse(Console.ReadLine(), out int selection))
        {
            switch (selection)
            {
                case 1:
                    CreateSimpleGoal();
                    break;

                case 2:
                    CreateEternalGoal();
                    break;

                case 3:
                    CreateChecklistGoal();
                    break;

                default:
                    Console.WriteLine("That is not a valid input. Please try again.");
                    break;
            }
        }
    }

    private static void CreateSimpleGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        SimpleGoal goal = new SimpleGoal("Simple", title, description, points);
        goalManager.AddGoal(goal);
    }

    private static void CreateEternalGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        EternalGoal goal = new EternalGoal("Eternal", title, description, points);
        goalManager.AddGoal(goal);
    }

    private static void CreateChecklistGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        ChecklistGoal goal = new ChecklistGoal("Checklist", title, description, points, target, 0, bonus);
        goalManager.AddGoal(goal);
    }

}
