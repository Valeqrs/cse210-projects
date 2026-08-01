// Program.cs
using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 videos
            Video video1 = new Video("C# Basics", "John Doe", 600);
            Video video2 = new Video("OOP Principles", "Jane Smith", 1200);
            Video video3 = new Video("LINQ in Depth", "Bob Johnson", 900);

            // Add comments to video1
            video1.AddComment(new Comment("Alice", "Great introduction!"));
            video1.AddComment(new Comment("Bob", "Very clear, thanks."));
            video1.AddComment(new Comment("Charlie", "Helped me a lot."));

            // Add comments to video2
            video2.AddComment(new Comment("Diana", "Excellent explanation of inheritance."));
            video2.AddComment(new Comment("Eve", "I finally understand polymorphism."));
            video2.AddComment(new Comment("Frank", "Could you make a video on interfaces?"));

            // Add comments to video3
            video3.AddComment(new Comment("Grace", "LINQ is so powerful!"));
            video3.AddComment(new Comment("Heidi", "I love the examples."));
            video3.AddComment(new Comment("Ivan", "Please cover deferred execution."));

            // Put all videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate and display
            foreach (Video video in videos)
            {
                // Use local variables (camelCase)
                string title = video.GetTitle();
                string author = video.GetAuthor();
                int length = video.GetLengthSeconds();
                int commentCount = video.GetNumberOfComments();

                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Length: {length} seconds");
                Console.WriteLine($"Number of comments: {commentCount}");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    string commenter = comment.GetCommenterName();
                    string text = comment.GetCommentText();
                    Console.WriteLine($"  - {commenter}: {text}");
                }

                Console.WriteLine(); // Blank line between videos
            }
        }
    }
}