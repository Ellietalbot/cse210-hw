using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!\n");

        Address address1 = new Address("123 Aspen Road", "Rexburg", "Idaho", "US");
        Lecture lecture1 = new Lecture("The History of Clue", "A lecture by Professor Plum on the impact of Clue on our past and future.", "October 9, 2025", "6:00PM", "Lecture", address1, "Professor Plum", 100);

        lecture1.ReturnStandardDetails();
        Console.WriteLine();
        lecture1.ReturnShortDescription();
        Console.WriteLine();
        lecture1.ReturnFullDetails();
        
        Console.WriteLine("\n");

        Address address2 = new Address("123 Pine Street", "Rexburg", "Idaho", "US");
        Reception reception1 = new Reception("The Smith's Wedding", "Wedding reception for Mr. & Mrs. Smith", "November 2, 2025", "5:00PM", "Reception", address2, "Spycouple@gmail.com");

        reception1.ReturnStandardDetails();
        Console.WriteLine();
        reception1.ReturnShortDescription();
        Console.WriteLine();
        reception1.ReturnFullDetails();

        Console.WriteLine("\n");

        Address address3 = new Address("123 Elm Ave.", "Rexburg", "ID", "US");
        OutdoorEvent outdoorEvent1 = new OutdoorEvent("Farmers Market", "Come and gather with the community to share fresh produce and locally produced goods.", "August 23, 2025", "3:00PM", "Outdoor Event", address3, "Sunny");

        outdoorEvent1.ReturnStandardDetails();
        Console.WriteLine();
        outdoorEvent1.ReturnShortDescription();
        Console.WriteLine();
        outdoorEvent1.ReturnFullDetails();
    }
}
