using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        // Console.WriteLine("Hello Foundation1 World!");
        Comment comment1 = new("Jeffery Bezos", "Does it work with a blue chair?", 2024, 5, 2);
        

        Video video1 = new("True blue man", "How to pick up a blue chair", 2024, 5, 1);
        video1.AddComment(comment1);
        

        video1.DisplayAllVideoInfo();
        video1.DisplayComments();


    }
}