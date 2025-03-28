using System;

class Program
{
    static void Main(string[] args)
    {


        Video video1 = new Video("I Trained My Dog to Order Pizza… and Now I am Broke", "BarkAndBite", 120);

        video1.AddComment(new Comment("DoggoLover99",  "Next step: Train him to pay for it!"));
        video1.AddComment(new Comment("CheeseOverload", "Imagine the delivery guy showing up and your dog just woofs, signs the receipt, and takes the pizza."));
        video1.AddComment(new Comment("BrokeButFed",  "I need this skill. My dog only knows how to eat my credit card, not use it."));
        video1.Display();

        Video video2 = new Video("Trying to Be Productive… But Failing Miserably", "Name McName", 320);

        video2.AddComment(new Comment("ProcrastinationKing", "Watching this video instead of being productive. The irony is strong."));  
        video2.AddComment(new Comment("SleepySloth", "Step 1: Make a to-do list. Step 2: Take a nap. Step 3: Panic."));  
        video2.AddComment(new Comment("TooManyTabsOpen", "Productivity tip: Open 27 tabs so it looks like you're working!"));  
        video2.Display();

        Video video3 = new Video("Cooking Disaster: Why I Shouldn't Be Allowed in the Kitchen", "Chef Nope", 450);

        video3.AddComment(new Comment("BurntToast42", "Recipe said let simmer for 10 minutes. I let it simmer for 10 seconds before panicking."));  
        video3.AddComment(new Comment("KitchenNightmare", "I tried following a recipe once. Now my smoke detector is my cooking timer."));  
        video3.AddComment(new Comment("MicrowaveMaster", "Pro tip: If it says preheat oven to 350°F, just order pizza instead."));  
        video3.Display();



    }
}