using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int random_int = random.Next(1,101);
        int guess = -1;

        while (guess != random_int)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > random_int){
                Console.WriteLine("Lower");
            }
            else if (guess < random_int){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

