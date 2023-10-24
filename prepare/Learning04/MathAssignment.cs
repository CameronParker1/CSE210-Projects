public class MathAssignment : Assignment
{
    public string TextbookSection { get; set; }

    public string problems { get; set; }

    public string GetHomeworkList()
    {
        return $"{TextbookSection} {problems}";
    }
    
}