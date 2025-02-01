
class Menu
{
    public static void DisplayOptions()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("Write an entry: Press 1");
        Console.WriteLine("Display Journal: Press 2");
        Console.WriteLine("Save Journal to a File: Press 3");
        Console.WriteLine("Load Journal from File: Press 4");
        Console.WriteLine("Exit: Press 5");
    }

    public void GetUserSelection()
    {
        Journal journal1 = new Journal();
        bool running = true; // Loop the menu
        while (running)
        {
            int streak = journal1.GetStreak();
            Console.WriteLine($"📅 Current Journal Streak: {streak} days! Keep it going! \n");
            DisplayOptions();
            
            Console.Write("Enter your selection: ");
            string menuSelectionInput = Console.ReadLine();
            int menuSelection;

            if(int.TryParse(menuSelectionInput, out menuSelection)){
                switch (menuSelection)
                {
                    case 1:
                        journal1.WriteEntry();
                        break;
                    case 2:
                        journal1.Display();
                        break;
                    case 3:
                        journal1.saveJournal();
                        break;
                   case 4:
                        journal1.loadJournal();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("That is not a valid input. Please try again.");
                        break;
                }
            }


        }
    }


        public static void DisplayJournal(){
            
        
    }
}



