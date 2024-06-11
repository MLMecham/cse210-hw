using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<string> questionList = new()
        {
            "What is good today?", 
            "What went well today?",
            "How did you help somebody today?",
            "How did others help you?",
            "How did God help you today?"
        };
        List<string> reflectTopic = new()
        {
            "Think of a time when you stood up for someone else"
        };
        List<string> reflectQuestions = new()
        {
            "Why was this experience meaningful to you?"
        };

        // Define  main variables
        string choice;
        int intChoice;
        int integer;

        // Test the parent activity class
        Activity genericActivity = new("hello", "cool", "goodbye");
        
        
        


        Console.WriteLine("Welcome to the Mindfulness App");
        
        do
        {
        Console.WriteLine("Please enter a number to choose from the following activities:");
        Console.WriteLine("\n1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Stretching Activity");
        Console.WriteLine("5. Quit\n");
        
        choice = Console.ReadLine();
        intChoice = int.Parse(choice);
        Console.WriteLine("");

        if (intChoice < 1 || intChoice > 5)
        {
            Console.WriteLine("That number is not listed.");
        }
        
        } while (intChoice < 1 || intChoice > 5);

        if (intChoice == 1)
        {
            Breathing breathing = new("Taking time to practice mindfulness has many benefits. We hope that this exercise helps you relax.", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "You did great! We hope that you feel refreshed and ready to face the day with a new vigor.");

            // show the starting messages
            breathing.DisplayStartMessage();
            breathing.DisplayActivityDescriptor();

            // set the duration of the activity
            Console.Write("\nPlease enter the duration of the activity: ");
            integer = int.Parse(Console.ReadLine());
            breathing.SetDuration(integer);
            breathing.Animation();
            Console.WriteLine("");

            // start the activity
            breathing.BreatingActivity();
            Console.WriteLine("");

            // show the end message
            breathing.DisplayEndMessage();


        }

        else if (intChoice == 2)
        {
            // initialize the class for the activity
            Listing listing = new("Taking time to practice mindfulness has many benefits. We hope that this exercise helps you relax.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "You did great! We hope that you feel refreshed and ready to face the day with a new vigor.", questionList);

            // Display the starting messages
            listing.DisplayStartMessage();
            listing.DisplayActivityDescriptor();

            // set the duration of the activity
            Console.Write("\nPlease enter the duration of the activity: ");
            integer = int.Parse(Console.ReadLine());
            listing.SetDuration(integer);
            listing.Animation();
            Console.WriteLine("");
            Console.WriteLine("");
            
            // show the prompt
            Console.Write($"Prompt: ");
            listing.DisplayRandomPrompt();

            // start the listing activity
            listing.ListingActivity();
            Console.WriteLine();

            // show the number of items listed
            listing.DisplayResponseCount();

            // show the end message
            listing.DisplayEndMessage();
        }

        else if (intChoice == 3)
        {
            // initialize the class for the activity
            Reflect reflecting = new("Taking time to practice mindfulness has many benefits. We hope that this exercise helps you relax.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "You did great! We hope that you feel refreshed and ready to face the day with a new vigor.", reflectTopic, reflectQuestions);

            // Display the starting messages
            reflecting.DisplayStartMessage();
            reflecting.DisplayActivityDescriptor();

            // set the duration of the activity
            Console.Write("\nPlease enter the duration of the activity: ");
            integer = int.Parse(Console.ReadLine());
            reflecting.SetDuration(integer);
            reflecting.Animation();
            Console.WriteLine("");
            Console.WriteLine("");

            // diplay prompt
            reflecting.DisplayRandomPrompt();

            // start the activity
            reflecting.RefletingActivity();


            // show the end message
            reflecting.DisplayEndMessage();
        }

        else if (intChoice == 4)
        {
            Console.WriteLine("Stretching");
        }

        else 
        {
            Console.WriteLine("Thank you for coming. Come back soon.");
        }


        
        
        // reflecting.SetDuration(integer);
        // reflecting.DisplayRandomPrompt();
        // reflecting.RefletingActivity();



        // listing.DisplayRandomPrompt();
        // listing.ListingActivity();
        // listing.DisplayResponseCount();



        // breathing.DisplayStartMessage();
        // breathing.DisplayActivityDescriptor();
        // breathing.Wait();
        // breathing.BreatingActivity();
        // breathing.DisplayEndMessage();
        // breathing.Animation();
        

    }
}