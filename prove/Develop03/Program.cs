using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the scripture you would like to memorize?");
        string scripture = Console.ReadLine();

        Console.WriteLine("What is the scripture reference?");
        string referenceInput = Console.ReadLine();
        Reference reference = Reference.ParseReference(referenceInput);



        Scripture scripture1 = new Scripture(scripture);

        while (scripture1.GetWordsHidden() < scripture1.GetWordCount())
        {
            Console.Clear();
            reference.Display();
            scripture1.Display();

            Console.WriteLine("\nPress ENTER or SPACEBAR to hide more words, or any other key to exit...");
            var key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Spacebar)
            {
                break;
            }

            scripture1.HideRandomWord();
        }

        Console.Clear();
        reference.Display();
        scripture1.Display();
        Console.WriteLine("\nAll words are hidden. Press any key to exit.");
        Console.ReadKey();
    }

 
}
