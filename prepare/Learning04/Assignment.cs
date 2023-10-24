public class Assignment
{
    public string StudentName { get; set; }

    public string topic { get; set; }

    public string GetSummary()
    {
        return $"{StudentName} - {topic}";
    }
}