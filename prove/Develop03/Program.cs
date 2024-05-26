using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // This will become the scripture to memorize.
        // I will make a way to select from a list.
        string scriptureToMemorize = "Hello to all. Goodbye everybody.";
        Scripture scripture1 = new Scripture(scriptureToMemorize);
        Reference referecne1 = new Reference("1 Nephi", 3, 7, 7);
        Word word1 = new Word();
        string currentWord;


        // This will be the loop
        scripture1.SetRandom();
        

        currentWord = scripture1.GetRandomWord();
        word1.SetWord(currentWord);
        

        // Hide the word
        word1.HideWord();
        currentWord = word1.GetWord();
        

        // Return the word to the verse
        scripture1.SetRandomWord(currentWord);
        scripture1.ReturnHiddenWord();
        scripture1.SetVerse();




        referecne1.Display();
        scripture1.Dispaly();
        // scriputre1.DisplayList();







    }
}