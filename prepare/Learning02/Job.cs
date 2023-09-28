public class Job
{
    public string JobTitle { get; set; }    
    public string Company { get; set; }
    public string StartYear { get; set; }   
    public string EndYear { get; set; }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
