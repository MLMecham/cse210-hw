using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        // Define all of the basic variables here
        string newLine = Environment.NewLine;

        Console.WriteLine("Wecome to the Journal Program!");
        // Console.WriteLine("Hello Develop02 World!");



        // Define basic variables for the program
        string decision;
        List<string> responses = new List<string> { "yes", "y", "no", "n" };
        string ownPromptYN;


        do
        {
            // Display the menu options
            Console.WriteLine(newLine + "Please choose from the following options:");
            Console.WriteLine("1. Write a Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit Program");
            Console.Write("What would you like to do? (Select a number) ");
            decision = Console.ReadLine();

            // Apply the correct methods depending on the respsonse
            if (decision == "1")
            {
                
                do
                {Console.Write("Would you like to use one of the premade prompts? ");
                ownPromptYN = Console.ReadLine();
                ownPromptYN = ownPromptYN.ToLower();
                if (ownPromptYN == "yes" || ownPromptYN == "y")
                {
                    JournalEntry entry = JournalEntry.WriteEntry();
                    Journal.AddEntryToJournal(entry);
                }
                else if (ownPromptYN == "no" || ownPromptYN == "n")
                {
                    // make own prompt
                }
                } while (!responses.Contains(ownPromptYN));


            }

            else if (decision == "2")
            {
                Journal.DisplayJournal();
            }

            else if (decision == "3")
            {
                Console.WriteLine("3");
            }

            else if (decision == "4")
            {
                Console.WriteLine("4");
            }

            else if (decision == "5")
            {
                Console.WriteLine("5");
            }
            else
            {
                Console.WriteLine("Sorry, please select one of the following options");
            }

            // Console.Write("Press Enter to continue: ");
            // Console.ReadLine();

        } while (decision != "5");

        Console.WriteLine( newLine + "Thank you for using the program. Until next time." + newLine);
    }
}