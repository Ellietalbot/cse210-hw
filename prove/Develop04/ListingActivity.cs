class ListingActivity : Activity
{
    private List<string> userResponses = new List<string>(); 

    public ListingActivity(string title, string description) : base(title, description)
    {
    }

    public string GetRandomListPrompt()
    {
        Random random = new Random();
        string[] listPrompts = {
            "--What are you grateful for?--",
            "--What makes you happy?--",
            "--What are small things that bring you joy?--",
            "--What are moments from today that made you smile?--",
            "--Who are people in your life that support you?--",
            "--What are ways you can be kind to yourself?--",
            "--What are things you love about nature?--",
            "--What are activities that help you feel relaxed?--",
            "--What accomplishments, big or small, are you proud of?--",
            "--What are things you can do to take care of your mind and body?--", 
            "--What are memories that make you feel warm inside?--",
            "--What are things that inspire you?--",
            "--What are things that help you feel present in the moment?--",
            "--What words would you use to describe yourself positively?--",
            "--What are things that help you feel connected to others?--",
            "--What are ways you can show kindness to others?--",
            "--What are things that make you feel safe and secure?--",
            "--What places bring you a sense of peace?--",
            "--What are things you appreciate about yourself?--",
            "--What are ways you can bring more mindfulness into your daily routine?--"
        };
        return listPrompts[random.Next(listPrompts.Length)];
    }

    public void StartListingActivity()
    {
        Console.WriteLine($"Starting Listing Activity");
        PauseAnimation(3);
        Console.Clear();
        Console.WriteLine($"Activity will run for {GetDuration()} seconds, list as many responses as you can to the following prompt: ");
        Console.WriteLine(GetRandomListPrompt());
        
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        userResponses.Clear();



        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(listItem))
            {
                userResponses.Add(listItem);
            }
        }
        PrintResponses();

    }

    public void PrintResponses()
    {
    Console.WriteLine($"\nYou listed {userResponses.Count} items. Well Done!");
    
    if (userResponses.Count == 0)
    {
        Console.WriteLine("- (No responses were recorded.)");
    }
    else
    {
        foreach (string response in userResponses)
        {
            Console.WriteLine("- " + response);
        }
    }

    Console.WriteLine("\nPress Enter to continue...");
    
    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {
      
    }
    
    Console.Clear();  
    }
}

