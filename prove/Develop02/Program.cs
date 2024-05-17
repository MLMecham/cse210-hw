using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        // Define all of the basic variables here
        string newLine = Environment.NewLine;
        string decision;
        JournalEntry entry1 = new();
        Journal journal1 = new();
        List<string> responses = new List<string> { "yes", "y", "no", "n" };
        string ownPromptYN;

        Console.WriteLine("Wecome to the Journal Program!");
        // Console.WriteLine("Hello Develop02 World!");
        
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
                    entry1 = entry1.WriteEntry();
                    journal1.AddEntryToJournal(entry1);
                }
                else if (ownPromptYN == "no" || ownPromptYN == "n")
                {
                    entry1 = entry1.WriteOwnPromptEntry();
                    journal1.AddEntryToJournal(entry1);
                }
                } while (!responses.Contains(ownPromptYN));


            }

            else if (decision == "2")
            {
                journal1.DisplayJournal();
            }

            else if (decision == "3")
            {
                // Console.WriteLine("3");
                journal1 = new();
                Console.WriteLine(newLine);
                Console.WriteLine("Loading existing journal");
                Console.WriteLine("Please enter the name of the file. ie 'journal.txt'");
                string filename = Console.ReadLine();
                string[] savedJournal = System.IO.File.ReadAllLines(filename);

                // JournalEntry loadJournal = new();

                foreach (string line in savedJournal)
                {
                    JournalEntry loadJournal = new();
                    string[] parts = line.Split("|");

                    loadJournal._date = parts[0];
                    loadJournal._prompt = parts[1];
                    loadJournal._entry = parts[2];

                    journal1.currentJournal.Add(loadJournal);
                }
            }

            else if (decision == "4")
            {   
                Console.WriteLine(newLine);
                Console.WriteLine("Saving Current Journal:");
                Console.WriteLine("Please type in a file name to save the journal. ie 'journal.txt': ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {foreach (JournalEntry entry in journal1.currentJournal)
                    {
                    string line = entry._date + '|' +  entry._prompt + '|' + entry._entry;
                    outputFile.WriteLine($"{line}");
                    }
                }
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