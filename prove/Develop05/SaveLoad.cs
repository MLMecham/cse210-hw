using System.IO.Enumeration;
using System.Runtime.CompilerServices;

public class SaveLoad
{
    private List<Goal> _goalList = new();

    public List<Goal> LoadGoals()
{
    // Choose file
    string fileName;
    // filename = "myFile.txt";

    Console.Clear();
    Console.WriteLine("\n");
    Console.WriteLine("From what file should the goals be saved (ie: myFile.txt)");
    fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        string[] parts = line.Split(',');
        List<string> loadList = new List<string>(parts);
        if (loadList[0].ToString() == "1")
        {
            bool boolean = loadList[1].ToString().ToLower() == "true";

            int loadPoints = int.Parse(loadList[2]);
            string loadName = loadList[3];
            string loadDescription = loadList[4];

            _goalList.Add(new DiscreteGoal(boolean, loadPoints, loadName, loadDescription));

        }
        else if (loadList[0].ToString() == "2")
        {

            int loadPoints = int.Parse(loadList[1]);
            int loadCompleted = int.Parse(loadList[2]);
            string loadName = loadList[3];
            string loadDescription = loadList[4];

            _goalList.Add(new ContinuousGoal(loadPoints, loadCompleted, loadName, loadDescription));

        }
        else if (loadList[0].ToString() == "3")
        {
            bool boolean = loadList[1].ToString().ToLower() == "true";

            int loadPointsPerStep = int.Parse(loadList[2]);
            int loadPointsPerCompletion = int.Parse(loadList[3]);
            int loadTarget = int.Parse(loadList[4]);
            int loadProgress = int.Parse(loadList[5]);
            string loadName = loadList[6];
            string loadDescription = loadList[7];

            _goalList.Add(new MultiStepGoal(boolean, loadPointsPerStep, loadPointsPerCompletion, loadTarget, loadProgress, loadName, loadDescription));

        }
        else if (loadList[0].ToString() == "4")
        {
            bool boolean = loadList[1].ToString().ToLower() == "true";

            int loadPoints = int.Parse(loadList[2]);
            string loadName = loadList[3];
            string loadDescription = loadList[4];

            _goalList.Add(new BadDiscreteGoal(boolean, loadPoints, loadName, loadDescription));

    }}

    Console.WriteLine("\n\nLoading Successful\nPress enter to continue: ");
    Console.ReadLine();
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

                // Choose file
                string fileName;
                // fileName = "myFile.txt";
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("To what file should the goals be saved (ie: myFile.txt)");
                fileName = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{stringGoals}");
                }


                Console.WriteLine("\n\nSaving Successful\nPress enter to continue: ");
                Console.ReadLine();
    }
}