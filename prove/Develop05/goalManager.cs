using System.IO;
using System.Runtime.CompilerServices;

class GoalManager {
    private List<Goal> _goalList = new List<Goal>();
    private int _totalPoints = 0;
    private string _filename = "goals.txt";

public void AddGoal(Goal goal) {
        _goalList.Add(goal);
}
public void DeleteGoal()
{
    Console.WriteLine("Please select a goal to delete:");
    DisplayGoals();

    if (int.TryParse(Console.ReadLine(), out int selection))
    {
        if (selection >= 1 && selection <= GetGoalListCount())
        {
            Goal goalToDelete = GetGoalAt(selection - 1);

            Console.WriteLine($"Are you sure you want to delete \"{goalToDelete.GetDetails()}\"? (yes/no)");
            string confirmation = Console.ReadLine().Trim().ToLower();

            if (confirmation == "yes")
            {
                _goalList.RemoveAt(selection - 1);
                Console.WriteLine("Goal deleted successfully!");
            }
            else
            {
                Console.WriteLine("Goal deletion canceled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}


public void DisplayGoals() {
    Console.WriteLine($"Total Points: {_totalPoints}");
    int goalNumber = 1;
    foreach (Goal goal in _goalList) {
        
        if (goal.GetType().Name != "ChecklistGoal") {
            Console.WriteLine($"{goalNumber}.[{(goal.GetCompletionStatus() ? "X" : " ")}] {goal.GetTitle()} ({goal.GetDescription()})");
        }
        else if (goal.GetType().Name == "ChecklistGoal") {
            
            ChecklistGoal checklistGoal = (ChecklistGoal)goal;
            Console.WriteLine($"{goalNumber}.[{(goal.GetCompletionStatus() ? "X" : " ")}] {goal.GetTitle()} ({goal.GetDescription()}) -- Currently Completed {checklistGoal.GetCurrentCount()}/{checklistGoal.GetTargetCount()}");
        }
        else {
            Console.WriteLine("Error");
        }
        goalNumber++;
    }
    
}




public void SaveGoals() {
    Console.WriteLine("Saving Goals...");
    try {
        using (StreamWriter outputFile = new StreamWriter(_filename, false, System.Text.Encoding.UTF8)) {

            outputFile.WriteLine(_totalPoints);


            foreach (Goal goal in _goalList) {
                if (goal is SimpleGoal simpleGoal) {
                    outputFile.WriteLine($"SimpleGoal: {simpleGoal.GetTitle()}, {simpleGoal.GetDescription()}, {simpleGoal.GetPoints()}, {simpleGoal.GetCompletionStatus()}");
                } else if (goal is EternalGoal eternalGoal) {
                    outputFile.WriteLine($"EternalGoal: {eternalGoal.GetTitle()}, {eternalGoal.GetDescription()}, {eternalGoal.GetPoints()}");
                } else if (goal is ChecklistGoal checklistGoal) {
                    outputFile.WriteLine($"ChecklistGoal: {checklistGoal.GetTitle()}, {checklistGoal.GetDescription()}, {checklistGoal.GetPoints()}, {checklistGoal.GetCurrentCount()}, {checklistGoal.GetTargetCount()}, {checklistGoal.GetCompletionStatus()}, {checklistGoal.GetBonusPoints()}");
                }
            }
        }
        Console.WriteLine("Goals saved successfully! Check 'goals.txt'");
    } catch (Exception ex) {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }
}

public void LoadGoals() {
    if (!File.Exists(_filename)) {
        Console.WriteLine("No saved goals found!");
        return;
    }

    try {
        string[] lines = File.ReadAllLines(_filename);

        if (lines.Length > 0) {
            _totalPoints = int.Parse(lines[0]);
            Console.WriteLine($"Total Points: {_totalPoints}");
            int goalNumber = 1;

            for (int i = 1; i < lines.Length; i++) {
                string line = lines[i];
                string[] parts = line.Split(':');

                if (parts.Length == 2) {
                    string goalType = parts[0].Trim();
                    string[] detailsParts = parts[1].Split(',');

                    goalType = goalType.Replace(" ", "");

                    Goal goal = null;

                    if (goalType == "SimpleGoal" && detailsParts.Length >= 4) {
                        string title = detailsParts[0];
                        string description = detailsParts[1];
                        int points = int.Parse(detailsParts[2]);
                        
                        
                        bool completed = ParseBoolean(detailsParts[3]);

                        
                        goal = new SimpleGoal(goalType, title, description, points);
                        if (completed) goal.IsComplete();  
                        
                        Console.WriteLine($"{goalNumber}.[{(completed ? "X" : " ")}] {title} ({description})");
                    } else if (goalType == "EternalGoal" && detailsParts.Length >= 3) {
                        string title = detailsParts[0];
                        string description = detailsParts[1];
                        int points = int.Parse(detailsParts[2]);

                        goal = new EternalGoal(goalType, title, description, points);
                        Console.WriteLine($"{goalNumber}.[ ] {title} ({description})");
                    } else if (goalType == "ChecklistGoal" && detailsParts.Length >= 6) {
                        string title = detailsParts[0];
                        string description = detailsParts[1];
                        int points = int.Parse(detailsParts[2]);
                        int currentCount = int.Parse(detailsParts[3]);
                        int targetCount = int.Parse(detailsParts[4]);
                        
                        
                        bool completed = ParseBoolean(detailsParts[5]);

                        int bonus = int.Parse(detailsParts[6]);

                        goal = new ChecklistGoal(goalType, title, description, points, currentCount, targetCount, bonus);
                        if (completed) goal.IsComplete();  

                        Console.WriteLine($"{goalNumber}.[{(completed ? "X" : " ")}] {title} ({description}) -- Currently Completed {currentCount}/{targetCount}");
                    } else {
                        Console.WriteLine($"Skipping invalid line: {line}");
                    }

                    if (goal != null) {
                        _goalList.Add(goal);
                    }
                } else {
                    Console.WriteLine($"Skipping malformed line: {line}");
                }
                goalNumber++;
            }
        } else {
            Console.WriteLine("File is empty!");
        }
    } catch (Exception ex) {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
}
public void RecordGoalEvent()
    {
        Console.WriteLine("Please select a goal to record an event for:");
        DisplayGoals();

        if (int.TryParse(Console.ReadLine(), out int selection))
        {
            if (selection >= 1 && selection <= GetGoalListCount())
            {
                Goal selectedGoal = GetGoalAt(selection - 1);
                int pointsEarned = selectedGoal.RecordEvent();
                AddPoints(pointsEarned);  

                Console.WriteLine($"Total Points: {GetTotalPoints()}");
            }
            else
            {
                Console.WriteLine("Invalid goal selection. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

private bool ParseBoolean(string value) {
    return value.Trim().ToLower() == "true";
}
public int GetGoalListCount()
{
    return _goalList.Count;
}

public Goal GetGoalAt(int index)
{
    return _goalList[index];
}
public void AddPoints(int points)
    {
        _totalPoints += points;
    }

public int GetTotalPoints()
    {
        return _totalPoints;
    }





} 