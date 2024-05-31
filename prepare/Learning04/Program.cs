using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment simple = new("Mitchell", "Roblox");

        // string basic = simple.GetSummary();
        // Console.WriteLine(basic);

        MathAssignment math = new("Mitchell", "Division", "5.4", "19-97");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new("Mitchell", "English", "Hundred Years of Solitude");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        

    }
}