using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2022;
        job1._endYear = 2024;

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2024;
        job2._endYear = 2025;

        // job1.Display();
        // job2.Display();

        Resume resume1 = new Resume();

        resume1._firstName = "Flavien";
        resume1._lastName = "Mabouba";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine($"{resume1._jobs[0]._jobTitle}");

        resume1.Display();

    }
}