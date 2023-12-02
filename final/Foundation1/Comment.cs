public class Comment 
{
    public string Name;
    public string Comments;
    
    public void DisplayComments()
    {
        Console.WriteLine("");
        Console.WriteLine($"{Name}");
        Console.WriteLine("");
        Console.WriteLine($"    - {Comments}");
    }
}