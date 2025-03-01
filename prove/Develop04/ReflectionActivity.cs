using System;
using System.Runtime.CompilerServices;
using System.Threading;

class ReflectionActivity : Activity
{



    public ReflectionActivity(string title, string description) : base(title, description)
    {
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        string [] prompts = [    "-- Think of a time when you completed something difficult. --",
                                    "-- Think of a time when you felt inspired. --",
                                    "-- Recall a moment when you helped someone in need. --",
                                    "-- Think of a challenge you faced and how you overcame it. --",
                                    "-- Remember a time when you felt truly grateful. --",
                                    "-- Reflect on a time when you learned something valuable from a mistake. --",
                                    "-- Think of a person who has positively influenced your life. --",
                                    "-- Recall a moment when you stepped out of your comfort zone. --",
                                    "-- Think of a time when you showed kindness to someone. --",
                                    "-- Reflect on an experience that made you feel proud of yourself. --",
                                    "-- Remember a time when you worked hard towards a goal. --",
                                    "-- Think of a situation where you demonstrated patience. --",
                                    "-- Recall a moment when you felt deep joy or happiness. --",
                                    "-- Reflect on a time when you supported a friend or loved one. --",
                                    "-- Think of a time when you made a difficult but important decision. --"];
        string [] chosenPrompts = [];
        int randomIndex = random.Next(0, prompts.Length);
        string random_prompt = prompts[randomIndex];
        return random_prompt;
    }
        public string GetRandomFollowUpQ(){
        Random random = new Random();
        string[] followupQ = [
            "What did you learn about yourself from this experience?",
            "How did this moment shape who you are today?",
            "What emotions did you experience during this time, and how did you handle them?",
            "What would you do differently if you faced a similar situation again?",
            "How did this experience challenge or reinforce your beliefs or values?",
            "Who or what supported you during this time?",
            "What strengths did you discover in yourself during this experience?",
            "If you could offer advice to someone going through something similar, what would it be?",
            "What changes did this experience inspire in your actions, mindset, or goals?",
            "How has your perspective on life or people changed since then?",
            "What impact do you think this experience had on the people around you?",
            "What were the key takeaways from this moment, and how can you apply them moving forward?",
            "Did this experience help you develop a new skill or way of thinking?",
            "Looking back, how would you describe this moment in one word, and why?",
            "What are you most grateful for as a result of this experience?"
        ];

        int randomIndex = random.Next(0, followupQ.Length);
        return followupQ[randomIndex];
    }

    public void startReflectionActivity()
    {
        Console.WriteLine("Starting Reflection Exercise...");
        PauseAnimation(1);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine("When you have something in mind press Enter to continue.");
            

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                while (DateTime.Now < endTime)
                {
                    
                    Console.WriteLine();
                    Console.Write($"> {GetRandomFollowUpQ()} ");
                    PauseAnimation(4);
            
                }

            }


        Console.WriteLine("Reflection exercise complete!");
    }
}