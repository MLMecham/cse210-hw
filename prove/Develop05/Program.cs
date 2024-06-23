using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        int iteration;
        int totalScore;
        int pointsEarned;
        string answer = " ";
        List<Goal> goalList = new();

        DiscreteGoal dg1 = new (false, 100, "do homework", "complete all assignments for the week");
        goalList.Add(dg1);
        ContinuousGoal cg1 = new (50, 0, "read scriptures", "enhance gospel knowledge by reading scriptures");
        goalList.Add(cg1);
        MultiStepGoal mg1 = new (false, 50, 100, 2, 0, "Protein Power", "eat chicken 10 times");
        goalList.Add(mg1);


        while (answer != "6")
        {
            

            if (answer == "1")
            {
                Console.WriteLine("\nWhich kind of goal would you like to create?");
                Console.WriteLine("\t1. Discrete Goal");
                Console.WriteLine("\t2. Continuous Goal");
                Console.WriteLine("\t3. Multi-Step Goal");

                Console.Write("Select a choice from the menu: ");
                answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points earned by completion: ");
                    string points = Console.ReadLine();
                    int intPoints = int.Parse(points);

                    goalList.Add(new DiscreteGoal(false, intPoints, name, description));



                }
                else if (answer == "2")
                {
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points earned by completion: ");
                    string points = Console.ReadLine();
                    int intPoints = int.Parse(points);

                    goalList.Add(new ContinuousGoal(intPoints, 0, name, description));

                }
                else if (answer == "3")
                {
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("How many times do you want to complete the action: ");
                    string target = Console.ReadLine();
                    int intTarget = int.Parse(target);
                    Console.Write("How many points earned for each step: ");
                    string points = Console.ReadLine();
                    int intPoints = int.Parse(points);
                    Console.Write("How many bonus points for reaching your goal: ");
                    string bonus = Console.ReadLine();
                    int intBonus = int.Parse(bonus);
                    
                    

                    goalList.Add(new MultiStepGoal(false, intPoints, intBonus, intTarget, 0, name, description));

                }


            }
            else if (answer == "2")
            {
                iteration = 1;
                Console.WriteLine("\nGoals:");

                foreach (Goal goal in goalList)
                {
                    Console.Write($"{iteration}. ");
                    goal.DisplayGoal();
                    iteration ++;
                }

                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }
            else if (answer == "3")
            {
                Console.WriteLine("Save Animation");
            }
            else if (answer == "4")
            {
                Console.WriteLine("Load Animation");
            }
            else if (answer == "5")
            {
                iteration = 1;
                Console.WriteLine("\nGoals:");

                foreach (Goal goal in goalList)
                {
                    Console.Write($"{iteration}. ");
                    goal.DisplayGoal();
                    iteration ++;
                }

                Console.Write("Select the goal that you want to update: ");
                answer = Console.ReadLine();

                goalList[int.Parse(answer) - 1].UpdateGoal();
            }

            totalScore = 0;
            foreach (Goal goal in goalList)
                {
                    
                    pointsEarned = goal.CalculateScore();
                    totalScore += pointsEarned;
                }
            Console.WriteLine($"\nPoints: {totalScore}");

            Console.WriteLine("\nMenu Options");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Goal Progress");
            Console.WriteLine("\t6. Quit");

            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();


        }
        // iteration = 1;
        // foreach (Goal goal in goalList)
        // {
        //     Console.Write($"{iteration}. ");
        //     goal.DisplayGoal();
        //     iteration ++;
        // }

        // dg1.DisplayGoal();
        // cg1.DisplayGoal();
        // mg1.DisplayGoal();

    }
}