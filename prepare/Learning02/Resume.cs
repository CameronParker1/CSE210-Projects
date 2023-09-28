public class Resume 
{
    public string Name;

    public List<Job> job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in job)
        {
            job.Display();
        }
    }

}



