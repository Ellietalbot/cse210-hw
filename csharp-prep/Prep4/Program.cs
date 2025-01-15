using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = 1;
        while (number != 0){
            Console.WriteLine("Input a number to make a list of numbers, type 0 when done. ");
            Console.WriteLine("What number would you  like to add to the list? ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }
        }

        int sum = 0;
        int len = 0;
        int largest = 0;

        foreach (int i in numbers){
            sum += i;
            len ++;
            if (i > largest){
                largest = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / len;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");

    }
}