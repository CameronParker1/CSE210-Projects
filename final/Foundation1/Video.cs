public class Video
{
    public string Title;
    public string Author;
    public int Length;

    public List<Comment> comment = new List<Comment>();
    
    
    public int GetTotalComments(List<Comment> comment)
    {
        int totalComments = comment.Count;
        return totalComments;
    }
    
    public void Display()
    {
        Console.WriteLine($"Video Title: {Title} \nAuthor: {Author} \nVideo Length: {Length} seconds \nComments ({GetTotalComments(comment)})");
        Console.WriteLine("");
        Console.WriteLine("Comment Section: ");

        foreach (Comment comment in comment)
        {
            comment.DisplayComments();
            Console.WriteLine("");
        }
    }
}