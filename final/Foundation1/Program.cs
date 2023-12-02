using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.Title = "How to make a paper airplane";
        video1.Author = "Oragami Guy";
        video1.Length = 480; 

        Video video2 = new Video();
        video2.Title = "How to change a flat tire";
        video2.Author = "Fix it Felix";
        video2.Length = 1020; 

        Video video3 = new Video();
        video3.Title = "Skydiving into the Grand Canyon";
        video3.Author = "Adrenaline Man";
        video3.Length = 300; 

        Video video4 = new Video();
        video4.Title = "Alaska fishing trip";
        video4.Author = "Outdoor Addict";
        video4.Length = 780; 


        List<Video> videos = new()
        {
            video1,
            video2,
            video3,
            video4
        };
        

        // Video 1 Comments
        Comment comment1 = new Comment();
        comment1.Name = "Oliver";
        comment1.Comments = "So cool! Thanks for sharing!";
        video1.comment.Add(comment1);
        
        Comment comment2 = new Comment();
        comment2.Name = "Maya";
        comment2.Comments = "My son loves making paper airplanes! Your video was so helpful!";
        video1.comment.Add(comment2);

        Comment comment3 = new Comment();
        comment3.Name = "Xavier";
        comment3.Comments = "I am now a master at making paper airplanes! Thanks for the help!";
        video1.comment.Add(comment3);

        // Video 2 Comments
        Comment comment4 = new Comment();
        comment4.Name = "Zoe";
        comment4.Comments = "Your tutorial was so helpful! Thanks!";
        video2.comment.Add(comment4);

        Comment comment5 = new Comment();
        comment5.Name = "Mason";
        comment5.Comments = "You are a great teacher and your video helped me get back on the road when I got a flat!";
        video2.comment.Add(comment5);

        Comment comment6 = new Comment();
        comment6.Name = "Ava";
        comment6.Comments = "This was a very detailed video and had a lot of helpful hints! Thanks for the extra knowledge and help!";
        video2.comment.Add(comment6);

        // Video 3 Comments
        Comment comment7 = new Comment();
        comment7.Name = "Elijah";
        comment7.Comments = "This guy is crazy!";
        video3.comment.Add(comment7);

        Comment comment8 = new Comment();
        comment8.Name = "Isabella";
        comment8.Comments = "I want to do this so bad some day!";
        video3.comment.Add(comment8);

        Comment comment9 = new Comment();
        comment9.Name = "Caleb";
        comment9.Comments = "That must have been such a rush! Very cool to see on video!";
        video3.comment.Add(comment9);

        // Video 4 Comments
        Comment comment10 = new Comment();
        comment10.Name = "Scarlett";
        comment10.Comments = "Man that was a huge fish!";
        video4.comment.Add(comment10);

        Comment comment11 = new Comment();
        comment11.Name = "Leo";
        comment11.Comments = "Such a beautiful scenery! It is one of my dreams to do this some day!";
        video4.comment.Add(comment11);

        Comment comment12 = new Comment();
        comment12.Name = "Sophia";
        comment12.Comments = "You are an expert fisherman! Nice job!";
        video4.comment.Add(comment12);


        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}