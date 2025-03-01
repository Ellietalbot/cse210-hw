using System;

class Program

{
    private int activitiesPerformed = 0;
    public void Run()
    {
        Console.WriteLine("Hello Develop04 World!");

        bool running = true;
        while (running)
        {
            running = Menu();
        }
        
    }

    public bool Menu()
    {
        Console.Clear();
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int menuChoice))
        {
            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathingActivity1 = new BreathingActivity(
                        "Breathing Activity!", 
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing."
                    );
                    breathingActivity1.displayStartMessage();
                    breathingActivity1.StartBreathingActivity();
                    breathingActivity1.displayEndMessage();
                    activitiesPerformed++;
                    
                    break;

                case 2:
                    Console.Clear();
                    ReflectionActivity reflectionActivity1 = new ReflectionActivity(
                        "Reflection Activity", 
                        "This activity helps you reflect on past experiences and gain insights."
                    );
                    reflectionActivity1.displayStartMessage();
                    reflectionActivity1.startReflectionActivity();
                    reflectionActivity1.displayEndMessage();
                    activitiesPerformed++;

                    break;

                case 3:
                    Console.Clear();
                    ListingActivity listingActivity1 = new ListingActivity(
                        "Listing Activity", 
                        "This activity encourages you to list things related to a given topic to help you increase happiness and gratitude"
                    );
                    listingActivity1.displayStartMessage();
                    listingActivity1.StartListingActivity();
                    listingActivity1.displayEndMessage();
                    activitiesPerformed++;

                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Exiting program...");
                    Console.WriteLine($"You completed {activitiesPerformed} activities!");
                    Thread.Sleep(3000);
                    Console.Clear();

                    return false;

                default:
                    Console.WriteLine("That is not a valid input. Please try again.");
                    Console.Clear();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        return true;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        
        program.Run();
    }
}
