public class Activity {
    private string _title;
    private string _description;
    private int _duration;

    public Activity(string title, string description){
        _title = title;
        _description = description;
    }
    public void displayStartMessage(){
        Console.WriteLine($"Welcome to the {_title}!");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"How long in seconds would you like your session? ");
        string seconds_input = Console.ReadLine();
        _duration = int.Parse(seconds_input);

        

    }

    public  void displayEndMessage(){
        Console.WriteLine($"You have completed {_duration} seconds of the {_title}!");
        Thread.Sleep(3000);

    }

    public int GetDuration(){
        return _duration;
    }

    

    public void PauseAnimation(int duration){
        int i = 0;
        
        while(i < duration){

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            i += 1;

        }

    }

}