public class Resume
{
    public string _lastName;
    public string _firstName;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
} 
