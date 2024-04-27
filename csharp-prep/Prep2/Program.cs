using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // This is a test edit.
        Console.Write("Please enter your grade percentage: ");
        string gradePercentageString_ML =  Console.ReadLine();

        int gradePercentageInt_ML = int.Parse(gradePercentageString_ML);
        string letterGrade_ML;
        string plusOrMinus_ML;

        if (gradePercentageInt_ML >= 90)
        {letterGrade_ML = "A";}
        else if (gradePercentageInt_ML >= 80)
        {letterGrade_ML = "B";}
        else if (gradePercentageInt_ML >= 70)
        {letterGrade_ML = "C";}
        else if (gradePercentageInt_ML >= 60)
        {letterGrade_ML = "D";}
        else
        {letterGrade_ML = "F";}

        if (gradePercentageInt_ML >= 93)
        {plusOrMinus_ML = "";}
        else if (gradePercentageInt_ML < 60)
        {plusOrMinus_ML = "";}
        else if (gradePercentageInt_ML % 10 >= 7)
        {plusOrMinus_ML = "+";}
        else if (gradePercentageInt_ML % 10 <= 3)
        {plusOrMinus_ML = "-";}
        else
        {plusOrMinus_ML = "";}
        
        Console.WriteLine($"Your final grade is {letterGrade_ML}{plusOrMinus_ML}");

        if (gradePercentageInt_ML >= 70)
        {Console.WriteLine("Congratulations! You passed the course.");}
        else
        {Console.WriteLine("You unfortunaltly did not pass the course. Study well for next semester and try again");}

    }
}