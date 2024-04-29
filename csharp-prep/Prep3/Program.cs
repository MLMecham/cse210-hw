using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // string response;

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        Random randomGenerator = new Random();
        int numberML = randomGenerator.Next(1,101);

        // Console.WriteLine(numberML);
        string userGuessML;
        int intUserGuessML;
        int numberOfGuessesML;
        string continueML;

        do
        {
            Console.WriteLine("Welcome to the number guessing game!");
            numberOfGuessesML = 0;

            
            do
            {
                Console.Write("Please guess the magic number: ");
                userGuessML = Console.ReadLine();
                intUserGuessML = int.Parse(userGuessML);
                numberOfGuessesML++;

                if (intUserGuessML == numberML)
                {
                    Console.WriteLine("Your guess is Correct! You win!");
                    Console.WriteLine($"It only took {numberOfGuessesML} guesses.");
                }
                else if (intUserGuessML > numberML)
                {
                    Console.WriteLine("Lower");
                }
                else if (intUserGuessML < numberML)
                {
                    Console.WriteLine("Higher");
                }
                
            } while (intUserGuessML != numberML);
            Console.WriteLine("");
                Console.Write("Would you like to play again? ");
                continueML = Console.ReadLine();
        } while (continueML == "yes");

        Console.WriteLine("");
        Console.WriteLine("Thank you for playing!");






    }
}