using System;
using System.Runtime.CompilerServices;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string title, string description) : base(title, description)
    {
    }

    public void StartBreathingActivity()
    {
        Console.WriteLine("Starting Breathing Exercise...");
        PauseAnimation(4);
        Console.Clear();

        int timeElapsed = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());


        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in..."); 
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);

            timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
            
        }

        Console.WriteLine("Breathing exercise complete!");
    }
    private void Countdown(int time){
        for (int i = time; i > 0; i --){
            Console.Write($"\r{i}");;
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
        Console.WriteLine();
    }
}