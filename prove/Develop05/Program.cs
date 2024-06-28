using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest!");
        int iteration;
        int totalScore;
        int pointsEarned;
        string answer = " ";
        List<Goal> goalList = new();

        // These are some classes to use for testing purposes

        // DiscreteGoal dg1 = new (false, 100, "do homework", "complete all assignments for the week");
        // goalList.Add(dg1);
        // ContinuousGoal cg1 = new (50, 0, "read scriptures", "enhance gospel knowledge by reading scriptures");
        // goalList.Add(cg1);
        // MultiStepGoal mg1 = new (false, 50, 100, 2, 0, "Protein Power", "eat chicken 2 times");
        // goalList.Add(mg1);
        // BadDiscreteGoal bg1 = new(false, 50, "don't die", "Your life must not end");
        // goalList.Add(bg1);


            Console.WriteLine("\nMenu Options");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Goal Progress");
            Console.WriteLine("\t6. Quit");

            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();


        while (answer != "6")
        {
            

            if (answer == "1")
            {
                Console.Clear();
                Console.WriteLine("\nWhich kind of goal would you like to create?");
                Console.WriteLine("\t1. Discrete Goal");
                Console.WriteLine("\t2. Continuous Goal");
                Console.WriteLine("\t3. Multi-Step Goal");
                Console.WriteLine("\t4. Bad Discrete Goal");

                Console.Write("Select a choice from the menu: ");
                answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.Write("\nEnter goal name: ");
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
                    Console.Write("\nEnter goal name: ");
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
                    Console.Write("\nEnter goal name: ");
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
                else if (answer == "4")
                {
                    Console.Write("\nEnter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points lost by completion: ");
                    string points = Console.ReadLine();
                    int intPoints = int.Parse(points);

                    goalList.Add(new BadDiscreteGoal(false, intPoints, name, description));



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
                // Save
                // List<string> saveList = new();
                // foreach (Goal goal in goalList)
                // {
                //     saveList.Add(goal.ToString());
                // }
                // string stringGoals = String.Join("\n", saveList);

                
                // string fileName = "myFile.txt";
                // using (StreamWriter outputFile = new StreamWriter(fileName))
                // {
                //     outputFile.WriteLine($"{stringGoals}");
                // }


                // Console.WriteLine("Saving Successful\nPress enter to continue: ");
                // Console.ReadLine();
                SaveLoad save = new();
                save.SaveGoals(goalList);
}
            else if (answer == "4")
            {
                // This is how I will formal the info from the txt doc.
                // string filename = "myFile.txt";
                // string[] lines = System.IO.File.ReadAllLines(filename);
                // foreach (string line in lines)
                // {
                //     Console.WriteLine("here-1");
                //     string[] parts = line.Split(',');
                //     List<string> loadList = new List<string>(parts);
                //         if (loadList[0].ToString() == "1")
                //         {
                //             Console.WriteLine("here");
                //             bool boolean;

                //             if (loadList[1].ToString() == "True" || loadList[1].ToString() == "true")
                //             {
                //                 boolean = true;
                //                 Console.WriteLine("here2");
                //             }
                //             else
                //             {
                //                 boolean = false;
                //                 Console.WriteLine("here2");
                //             }
                //             int loadPoints = int.Parse(loadList[2].ToString());
                //             Console.WriteLine("print3");
                //             string loadName = loadList[3].ToString();
                //             Console.WriteLine("print4");
                //             string loadDescription = loadList[4].ToString();
                //             Console.WriteLine("print5");
                //             goalList.Add(new DiscreteGoal(boolean, loadPoints, loadName, loadDescription));
                //             foreach (Goal thing in goalList)
                //             {
                //                 thing.DisplayGoal();
                //             }
                //         }
                //         else if (loadList[0].ToString() == "2")
                //         {
                //             Console.WriteLine("here");
                            
                //             int loadPoints = int.Parse(loadList[1].ToString());
                //             Console.WriteLine("print2");
                //             int loadCompleted = int.Parse(loadList[2]);
                //             Console.WriteLine("print3");
                //             string loadName = loadList[3].ToString();
                //             Console.WriteLine("print4");
                //             string loadDescription = loadList[4].ToString();
                //             Console.WriteLine("print5");
                //             goalList.Add(new ContinuousGoal(loadPoints, loadCompleted, loadName, loadDescription));
                //             foreach (Goal thing in goalList)
                //             {
                //                 thing.DisplayGoal();
                //             }
                //         }
                //         else if (loadList[0].ToString() == "3")
                //         {
                //             bool boolean;
                //             if (loadList[1].ToString() == "True" || loadList[1].ToString() == "true")
                //             {
                //                 boolean = true;
                //                 Console.WriteLine("here2");
                //             }
                //             else
                //             {
                //                 boolean = false;
                //                 Console.WriteLine("here2");
                //             }
                //             int loadPointsPerStep = int.Parse(loadList[2].ToString());
                //             Console.WriteLine("print3");
                //             int loadPointsPerCompletion = int.Parse(loadList[3].ToString());
                //             Console.WriteLine("print4");
                //             int loadTarget = int.Parse(loadList[4].ToString());
                //             Console.WriteLine("print5");
                //             int loadProgress = int.Parse(loadList[5].ToString());
                //             Console.WriteLine("print6");
                //             string loadName = loadList[6].ToString();
                //             Console.WriteLine("print7");
                //             string loadDescription = loadList[7].ToString();
                //             Console.WriteLine("print8");
                //             goalList.Add(new MultiStepGoal(boolean, loadPointsPerStep, loadPointsPerCompletion, loadTarget, loadProgress, loadName, loadDescription));
                //             foreach (Goal thing in goalList)
                //             {
                //                 thing.DisplayGoal();
                //             }
                //         }
                // }
                
                // saving and loading should delete the current goals loaded.
                SaveLoad load = new();
                List<Goal> loadList = new();
                loadList = load.LoadGoals();
                foreach (Goal goal in loadList)
                {
                    goalList.Add(goal);
                }


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
            Console.Clear();
            Console.WriteLine($"\nPoints: {totalScore}");

            if (totalScore > 999)
            {
                Console.WriteLine("level: 4");
                Console.WriteLine($"Progress to level 5: {totalScore}/{totalScore + 1} (So Close! Keep Trying!)");
            }
            else if (totalScore > 499)
            {
                Console.WriteLine("level: 3");
            }
            else if (totalScore > 66)
            {
                Console.WriteLine("level: 2");
            }
            else if (totalScore > 0)
            {
                Console.WriteLine("level: 1");
            }
            else if (totalScore < 0)
            {
                Console.WriteLine("level: :c");
            }
            
            
            

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