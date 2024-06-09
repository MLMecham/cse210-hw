using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<string> questionList = new()
        {
            "What is good today", 
            "What went well today",
            "How did you help somebody today"
        };
        List<string> reflectTopic = new()
        {
            "Think of a time when you stood up for someone else"
        };
        List<string> reflectQuestions = new()
        {
            "Why was this experience meaningful to you?"
        };

        // Test the parent activity class
        Activity genericActivity = new("hello", "cool", "goodbye");
        Breathing breathing = new("hello", "cool", "goodbye");
        Listing listing = new("hello", "cool", "goodbye", questionList);
        Reflect reflecting = new("hello", "cool", "goodbye", reflectTopic, reflectQuestions);
        // breathing.DisplayStartMessage();

        // breathing.DisplayActivityDescriptor();

        int integer = int.Parse(Console.ReadLine());
        breathing.Wait();
        reflecting.SetDuration(integer);
        reflecting.DisplayRandomPrompt();
        reflecting.RefletingActivity();



        // listing.DisplayRandomPrompt();
        // listing.ListingActivity();
        // listing.DisplayResponseCount();

        // breathing.BreatingActivity();
        // breathing.DisplayEndMessage();
        // breathing.Animation();
        

    }
}