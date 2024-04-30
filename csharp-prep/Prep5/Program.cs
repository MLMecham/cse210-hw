using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userNameML = Console.ReadLine();
            return userNameML;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite Integer: ");
            string userFavoriteIntML = Console.ReadLine();
            int intUserFavoriteIntML = int.Parse(userFavoriteIntML);
            return intUserFavoriteIntML;
        }

        static int SquareNumber(int numberToBeSquaredML)
        {
            int numberSquaredML = (int)Math.Pow(numberToBeSquaredML, 2);
            return numberSquaredML;
        }
        
        static void DisplayResult(string argumentOneML, int argumentTwoML)
        {
            Console.WriteLine($"Brother {argumentOneML}, The square of your number is {argumentTwoML}");
        }


        DisplayWelcome();
        string userNameML = PromptUserName();
        int userNumberML = PromptUserNumber();
        int squaredUserNumberML = SquareNumber(userNumberML);
        DisplayResult(userNameML, squaredUserNumberML);








    }   
}