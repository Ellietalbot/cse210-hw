using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Ellie", "C# HW");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Ellie", "C# HW", "Section 8.3", "Problems 1-18");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Ellie", "English 150", "The Significance of Pickles in 20th Century Asian Politics");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}