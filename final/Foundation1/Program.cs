using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> videoList = new();
        Console.Clear();
        // Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new("How to pick up a blue chair","Cosmic Oatis",  2024, 5, 1, 7);
        Comment comment1 = new("Jeffery Bezos", "Does it work with a red chair?", 2024, 5, 2);
        Comment comment2 = new("Cosmic Oatis", "No. Stop asking stupid qustions.", 2024, 6, 6);
        Comment comment3 = new("Jeffery Bezos", "Go commit scooter ankle you clanker.", 2024, 6, 7);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videoList.Add(video1);

        Video video2 = new("I sold Afghanistan to Iran!!!!!!","Mr Beast",  2027, 4, 1, 601);
        Comment comment4 = new("أحمد", "إيران هنا. نقترح عليك أن تفكر مرتين بشأن هذا \"البيع\" إذا كنت تقدر سلامك وهدوءك", 2027, 4, 1);
        Comment comment5 = new("Random Guy", "يا أخي، إنها كذبة إبريل. لم يتم بيع أي شيء.", 2027, 4, 2);
        Comment comment6 = new("أحمد", "مفهوم. شكرا لتذكيري. أحبك.", 2027, 4, 2);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videoList.Add(video2);


        Video video3 = new("https://www.youtube.com/watch?v=8ybW48rKBME", "xyzmusic", 2020,8,11, 207);
        Comment comment7 = new("Charlie", "Heck You!", 2022, 1, 1);
        Comment comment8 = new("Franklin", "Your parents don't love you after posting this", 2021, 12, 25);
        Comment comment9 = new("Javiar", "This is vile", 2023, 5, 15);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videoList.Add(video3);

        Video video4 = new("Watch Mr Gibbons sleep livestream (REAL)", "Ammon Kellar", 28800);
        Comment comment10 = new("Distinguished Gentlman", "A very soothing experience");
        Comment comment11 = new("Marvelous Man", "I missed the livestream. Could somebody post the link to the new video, please.");
        Comment comment12 = new("Refined Taste", "Here you go: https://www.youtube.com/watch?v=dQw4w9WgXcQ ");
        Comment comment13 = new("Marvelous Man", "Thank you so much!");

        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        video4.AddComment(comment13);
        videoList.Add(video4);






        Console.WriteLine("\n\n");
        foreach (Video video in videoList)
        {
            video.DisplayAllVideoInfo();
            video.DisplayComments();
            Console.WriteLine("\n\n");

        }

        
        

        


    }
}