using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Programming Tutorial", "CodeMaster", 1200);
        Video video2 = new Video("Object-Oriented Programming Basics", "TechGuru", 900);
        Video video3 = new Video("C# Collections Explained", "DotNetPro", 1500);

        // Add comments to video1
        video1.AddComment(new Comment("JohnDoe", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("AliceSmith", "Could you explain more about inheritance?"));
        video1.AddComment(new Comment("BobWilson", "The examples were clear and well-structured."));

        // Add comments to video2
        video2.AddComment(new Comment("CharlieBrown", "This helped me understand OOP concepts better."));
        video2.AddComment(new Comment("DianaRoss", "Please make more videos about design patterns."));
        video2.AddComment(new Comment("EdwardStark", "The real-world examples were very useful."));

        // Add comments to video3
        video3.AddComment(new Comment("FrankMiller", "Finally, someone who explains collections properly!"));
        video3.AddComment(new Comment("GraceLee", "Would love to see more advanced collection topics."));
        video3.AddComment(new Comment("HenryFord", "The performance comparison was eye-opening."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}