class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
        }
        else
        {
            foreach (Entry i in Entries)
            {
                i.Display();
            }
        }
    }
    public void WriteEntry()
    {
        Prompt prompt = new Prompt();
        string randomPrompt = prompt.GetPrompt();
        Console.WriteLine("\nJournal Prompt: " + randomPrompt);
        Console.WriteLine("Start writing your entry.");
        string entry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        Entry entry1 = new Entry(randomPrompt, dateText, entry);
        Entries.Add(entry1);
        Console.WriteLine("\nYour entry has been saved!\n");
    }
    public void saveJournal(){
        List<string> EntriesForExport  = new List<string>();
        foreach(Entry i in Entries){
            string line = i.DisplayForExport();
            EntriesForExport.Add(line);

        }
        string[] arrayofEntries =  EntriesForExport.ToArray();
        Console.WriteLine("Where do you want to store your journal?");
        string saveLocation = Console.ReadLine();
        System.IO.File.WriteAllLines(saveLocation, arrayofEntries);

    }
    public void loadJournal(){
        Console.WriteLine("Where do you want to load from?");
        string loadLocation = Console.ReadLine();
        string[] loadedArray = System.IO.File.ReadAllLines(loadLocation);
        foreach(string entry in loadedArray){
            Entry newEntry = new Entry(entry);
            Entries.Add(newEntry);
        }
    }
public int GetStreak()
{
    if (Entries.Count == 0)
        return 0;

    List<Entry> sortedEntries = Entries
        .Select(e => new { Entry = e, Date = DateTime.Parse(e._entryDateTime) })
        .OrderBy(e => e.Date)
        .Select(e => e.Entry)
        .ToList();

    int streak = 1;

    for (int i = sortedEntries.Count - 1; i > 0; i--)
    {
        DateTime currentDate = DateTime.Parse(sortedEntries[i]._entryDateTime);
        DateTime previousDate = DateTime.Parse(sortedEntries[i - 1]._entryDateTime);

        TimeSpan difference = currentDate.Date - previousDate.Date;

        if (difference.Days == 1)  // Consecutive day
        {
            streak++;
        }
        else if (difference.Days > 1)  // Break in streak
        {
            break;
        }
    }
    return streak;
}

}



