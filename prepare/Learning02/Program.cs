using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        

        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Senior Sofware Developer";
        job1._startYear = 1999;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._companyName = "Amazon";
        job2._jobTitle = "Cybersecurity Manager";
        job2._startYear = 2011;
        job2._endYear = 2023;

        Resume resume = new();
        resume._name = "Gregory Summers";
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);

        
        
        
        
        resume.DisplayResume();
        
        
    }
}