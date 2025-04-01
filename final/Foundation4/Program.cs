using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running("09 Sep 2023", "Running", 30, 4.64),
            new Cycling("09 Sep 2023", "Cycling", 30, 32),
            new Swimming("09 Sep 2023", "Swimming", 50, 90)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
