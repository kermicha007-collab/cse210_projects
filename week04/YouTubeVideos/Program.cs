using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("My Video", "John Doe", 120);
        Comment comment1 = new Comment("Jane Smith", "Great video!");
        Comment comment2 = new Comment("Mike Johnson", "Thanks for sharing!");
        Comment comment3 = new Comment("Emily Davis", "I learned a lot!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        

        Video video2 = new Video("Another Video", "Alice Johnson", 90);
        Comment comment4 = new Comment("Bob Brown", "Nice work!");
        Comment comment5 = new Comment("Charlie Wilson", "Very informative.");
        Comment comment6 = new Comment("David Lee", "I enjoyed watching this.");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Yet Another Video", "Charlie Davis", 150);
        Comment comment7 = new Comment("Diana Wilson", "Excellent content!");
        Comment comment8 = new Comment("Eve Thompson", "Well done!");
        Comment comment9 = new Comment("Frank Garcia", "I learned a lot from this.");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // collect videos for display
        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Video: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
            Console.WriteLine($"Comments:");


            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenter}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}