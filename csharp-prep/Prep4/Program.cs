using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbersML = new List<int>();
        string userInputML;
        int intUserInputML;
        string continueML = "";
        int sumML;
        float averageNumberML;
        int biggestNumberML = -10000000;
        int smallestPositiveNumberML = 10000000;


        do 
        {
            Console.Write("Enter a number: ");
            userInputML = Console.ReadLine();
            intUserInputML = int.Parse(userInputML);
            if (intUserInputML == 0)
            {
                break;
            }
            numbersML.Add(intUserInputML);

            // Console.Write("Would you like to add another number? ");
            // continueML = Console.ReadLine();

        } while (intUserInputML != 0);

        sumML = numbersML.Sum();
        averageNumberML = (float)sumML / (numbersML.Count());
        numbersML.Sort();
        

        foreach (int number in numbersML)
        {
            Console.WriteLine(number);
            if (number > biggestNumberML)
            {
                biggestNumberML = number;
            }
            if ((number > 0) && (number < smallestPositiveNumberML))
            {
                smallestPositiveNumberML = number;
            }
        }
        Console.WriteLine($"The sum of the numbers is {sumML}");
        Console.WriteLine($"The average number is {averageNumberML}");
        Console.WriteLine($"The biggest number is {biggestNumberML}");
        Console.WriteLine($"The samllest positive number is {smallestPositiveNumberML}");
    }
}