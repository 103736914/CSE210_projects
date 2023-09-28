using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1.Company = "Oscorp";
        job1.JobTitle = "Reactor Engineer";
        job1.StartYear = 2011;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.Company = "Macrosoft";
        job2.JobTitle = "Database Reverse-Engineer";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume joeResume = new Resume();
        joeResume.Name = "Joe Mansson";
        joeResume.Jobs.Add(job1);
        joeResume.Jobs.Add(job2);

        joeResume.Display();

    }
}

