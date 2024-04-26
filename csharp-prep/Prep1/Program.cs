using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.WriteLine("Hello Prep1 World!");
        // Console.Write("You are my friend, ");
        // Console.WriteLine("You are my sunshine");

        // Console.WriteLine("How old are you");
        // string age = Console.ReadLine();
        // int int_age = int.Parse(age);

        // if (int_age < 21)
        // {
        //     Console.WriteLine("You may not enter the secret club");
        // }
        // else if (int_age == 21)
        // {
        //     Console.WriteLine("You are barely old enough");
        // }
        // else 
        // {
        //     Console.WriteLine("You are very old. Enter please");
        // }

        // int age_plus_two = int_age + 2;
        // Console.WriteLine($"In two years you will be {age_plus_two} years old");


        //I know that you mentioned that we should put our innitials into our variables. I hope this is what you meant

        string ML_first_name;
        string ML_last_name;

        Console.Write("What is your first name? ");
        ML_first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        ML_last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {ML_last_name}, {ML_first_name} {ML_last_name}");
    }
}