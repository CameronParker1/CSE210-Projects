public class WritingAssignment : Assignment 
{
    public string title { get; set; }

    public string GetWritingInformation()
    {
        return title;
    }
}