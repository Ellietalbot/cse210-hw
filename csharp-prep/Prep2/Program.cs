using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade_percentage = Console.ReadLine();
        int percentage = int.Parse(grade_percentage);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80){
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage>=60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage <= 70)
        {
            Console.WriteLine("Keep Trying!");
        }
        else
        {
            Console.WriteLine("Great job! You passed the class!");
        }
    }
}