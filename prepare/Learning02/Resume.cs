using System.ComponentModel.DataAnnotations;

class Resume
{
    public List<Job> _jobList = new List<Job>();
    public string _name;

    public void DisplayResume()
    {
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobList)
        {
            job.Display();
            // job.DisplayStartYear();
        }
        Console.WriteLine("");
    }
}