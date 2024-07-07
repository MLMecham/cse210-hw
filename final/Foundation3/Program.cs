using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        DateTime test = new(2002,8,23,22,30,0);
        Address address1 = new("595 N 560 W", "American Fork", "Utah", "USA");
        Event event1 = new("title", "testing class", address1, 2002,8,23,22,30);
        // Console.Write(test.ToString("MMMM dd, yyyy "));
        // Console.Write(" at ");
        // Console.WriteLine(test.ToString("hh:mm tt"));

        // event1.DisplayStandardDetials();
        // event1.DisplayDateTime();

        Lecture lecture1 = new("Billy Joel", 50, 30, "title", "testing class", address1, 2002,8,23,22,30);
        lecture1.DisplayStandardDetials();
        lecture1.DisplayDateTime();

        Reception reception1 = new("mechamit000@gmail.com", 50, "mountain chic", "title", "testing class", address1, 2002,8,23,22,30);
        lecture1.DisplayStandardDetials();
        lecture1.DisplayDateTime();

        OutdoorGathering outdoorGathering1 = new("Sunny", "Sun Screen", "title", "testing class", address1, 2002,8,23,22,30);
        lecture1.DisplayStandardDetials();
        lecture1.DisplayDateTime();
    }
}