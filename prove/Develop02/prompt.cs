class Prompt  
{
    public  string GetPrompt()  
    {
        List<string> prompts = new List<string>
        {
            "What is something new you learned today?",
            "Describe a moment that made you smile recently.",
            "What are three things you're grateful for today?",
            "If you could travel anywhere, where would you go and why?",
            "Write a letter to your future self.",
            "What is one goal you want to achieve this month?",
            "Describe your ideal day from start to finish.",
            "What is something you're currently struggling with, and how can you overcome it?",
            "Write about a book, movie, or song that has influenced you.",
            "What is a childhood memory that makes you happy?"
        };
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(prompts.Count);
        return prompts[index];
    }
}
