using System.Runtime.CompilerServices;

public class SaveLoad
{
    private List<Goal> _goalList = new();

    public List<Goal> LoadGoals()
{
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        Console.WriteLine("here-1");
        string[] parts = line.Split(',');
        List<string> loadList = new List<string>(parts);
        if (loadList[0].ToString() == "1")
        {
            Console.WriteLine("here");
            bool boolean = loadList[1].ToString().ToLower() == "true";
            Console.WriteLine("here2");

            int loadPoints = int.Parse(loadList[2]);
            Console.WriteLine("print3");
            string loadName = loadList[3];
            Console.WriteLine("print4");
            string loadDescription = loadList[4];
            Console.WriteLine("print5");

            _goalList.Add(new DiscreteGoal(boolean, loadPoints, loadName, loadDescription));
            foreach (Goal thing in _goalList)
            {
                thing.DisplayGoal();
            }
        }
        else if (loadList[0].ToString() == "2")
        {
            Console.WriteLine("here");

            int loadPoints = int.Parse(loadList[1]);
            Console.WriteLine("print2");
            int loadCompleted = int.Parse(loadList[2]);
            Console.WriteLine("print3");
            string loadName = loadList[3];
            Console.WriteLine("print4");
            string loadDescription = loadList[4];
            Console.WriteLine("print5");

            _goalList.Add(new ContinuousGoal(loadPoints, loadCompleted, loadName, loadDescription));
            foreach (Goal thing in _goalList)
            {
                thing.DisplayGoal();
            }
        }
        else if (loadList[0].ToString() == "3")
        {
            bool boolean = loadList[1].ToString().ToLower() == "true";
            Console.WriteLine("here2");

            int loadPointsPerStep = int.Parse(loadList[2]);
            Console.WriteLine("print3");
            int loadPointsPerCompletion = int.Parse(loadList[3]);
            Console.WriteLine("print4");
            int loadTarget = int.Parse(loadList[4]);
            Console.WriteLine("print5");
            int loadProgress = int.Parse(loadList[5]);
            Console.WriteLine("print6");
            string loadName = loadList[6];
            Console.WriteLine("print7");
            string loadDescription = loadList[7];
            Console.WriteLine("print8");

            _goalList.Add(new MultiStepGoal(boolean, loadPointsPerStep, loadPointsPerCompletion, loadTarget, loadProgress, loadName, loadDescription));
            foreach (Goal thing in _goalList)
            {
                thing.DisplayGoal();
            }
        }
        else if (loadList[0].ToString() == "4")
        {
            Console.WriteLine("here");
            bool boolean = loadList[1].ToString().ToLower() == "true";
            Console.WriteLine("here2");

            int loadPoints = int.Parse(loadList[2]);
            Console.WriteLine("print3");
            string loadName = loadList[3];
            Console.WriteLine("print4");
            string loadDescription = loadList[4];
            Console.WriteLine("print5");

            _goalList.Add(new BadDiscreteGoal(boolean, loadPoints, loadName, loadDescription));
            foreach (Goal thing in _goalList)
            {
                thing.DisplayGoal();
            }
    }}

    return _goalList;
}


    public void SaveGoals(List<Goal> goalList)
    {
        List<string> saveList = new();
                foreach (Goal goal in goalList)
                {
                    saveList.Add(goal.ToString());
                }
                string stringGoals = String.Join("\n", saveList);

                
                string fileName = "myFile.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{stringGoals}");
                }


                Console.WriteLine("Saving Successful\nPress enter to continue: ");
                Console.ReadLine();
    }
}