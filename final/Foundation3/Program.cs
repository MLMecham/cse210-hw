using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("\n\n\n");
        


        DateTime test = new(2002,8,23,22,30,0);
        Address address2 = new("595 N 560 W", "American Fork", "Utah", "USA");
        Address address1 = new("Manwaring Center", "Rexburg", "Idaho", "USA");
        Address address3 = new("Fort Zachary Taylor State Park", "Key West", "Florida", "USA");
        Event event1 = new("title", "testing class", address1, 2002,8,23,22,30);
        // Console.Write(test.ToString("MMMM dd, yyyy "));
        // Console.Write(" at ");
        // Console.WriteLine(test.ToString("hh:mm tt"));

        // event1.DisplayStandardDetials();
        // event1.DisplayDateTime();
        Console.WriteLine("\nStandard Details Lecture");
        Lecture lecture1 = new("Billy Joel", 50, 30, "Learning To sing", "Join the famous Billy Joal as he teaches a new generation how to sing within a half hour. Bring your friends. Come early as there are only 50 seats!", address1, 2002,8,23,22,30);
        lecture1.DisplayStandardDetials();
        Console.WriteLine("\nShort Details Lecture");
        lecture1.DisplayShortDetails();
        Console.WriteLine("\nFull Details Lecture");
        lecture1.DisplayFullDetails();


        Console.WriteLine("\n\nStandard Details Reception");
        Reception reception1 = new("mechamit000@gmail.com", 50, "Mountain Chic", "Mountain Marriage", "Welcome to the union of mountian man and mountain woman. All are welcome but there are only 50 servings of food. Please RSVP soon in order to claim your mountain feast. You must fulfill the dress code in order to receive food.", address2, 2002,8,23,22,30);
        reception1.DisplayStandardDetials();
        Console.WriteLine("\nShort Details Reception");
        reception1.DisplayShortDetails();
        Console.WriteLine("\nFull Details Reception");
        reception1.DisplayFullDetails();


        Console.WriteLine("\n\nStandard Details Outdoor");
        OutdoorGathering outdoorGathering1 = new("Sunny", "Sun Screen", "Beach Party", "Schools out and it's time to swim. Please come ready to have a good time in the water.", address3, 2002,8,23,22,30);
        outdoorGathering1.DisplayStandardDetials();
        Console.WriteLine("\nShort Details Outdoor");
        outdoorGathering1.DisplayShortDetails();
        Console.WriteLine("\nFull Details Outdoor");
        outdoorGathering1.DisplayFullDetails();


    }
}