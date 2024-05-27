using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // This will become the scripture to memorize.
        // I will make a way to select from a list.
        string scriptureToMemorize = "Hello to all. Goodbye everybody.";
        scriptureToMemorize = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture1 = new Scripture(scriptureToMemorize);
        Reference referecne1 = new Reference("1 Nephi", 3, 7, 7);
        Word word1 = new Word();
        string currentWord;
        bool wordHidden;

        int wordCount = 0;
        int wordAlreadyHidden = 0;

        // Show the initial full scripture and reference
        Console.WriteLine("Try to memorize this scripture!");
        referecne1.Display();
        scripture1.Dispaly();


        Console.WriteLine(Environment.NewLine);
        Console.Write("Press Enter to remove three words or type 'quit' to exit the program.     ");
        string enterKey = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);

        // This will be the loop that checks for continue or quit
        
        while ((enterKey != "quit") && (wordAlreadyHidden <= 2000))
        {
            
            

            // This will be the loop that counts changes in the words
            wordAlreadyHidden = 0;
            while ((wordCount < 3) && (wordAlreadyHidden <= 2000))    
            {
                scripture1.SetRandom();
                

                currentWord = scripture1.GetRandomWord();
                word1.SetWord(currentWord);
                
                // Check if the word is already hidden and then choose path
                wordHidden = word1.GetIsHidden();
                if (wordHidden == false)
                {
                    // Hide the word
                    word1.HideWord();
                    currentWord = word1.GetWord();
                        

                    // Return the word to the verse
                    scripture1.SetRandomWord(currentWord);
                    scripture1.ReturnHiddenWord();
                    scripture1.SetVerse();
                    wordCount = wordCount + 1;
                    // scriputre1.DisplayList();
                }

                else
                {
                    wordAlreadyHidden = wordAlreadyHidden + 1;
                }
            } 

            // Display the scripture again to memorize.
            referecne1.Display();
            scripture1.Dispaly();
            wordCount = 0;

            Console.WriteLine(Environment.NewLine);
            Console.Write("Press Enter to remove three words or type 'quit' to exit the program.     ");
            enterKey = Console.ReadLine();
            


        } 


        

        Console.WriteLine("All of the words are hidden or you chose to quit. Hit enter to see if you can repeat the scripture");
        Console.ReadLine();

        referecne1.Display();
        scripture1.Dispaly();



    }
}