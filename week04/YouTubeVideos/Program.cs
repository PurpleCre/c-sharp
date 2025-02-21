using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the YouTubeVideos Project.\n");

        // insatiate comments list and add comments for first video
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("Great video!", "John"));
        comments1.Add(new Comment("I love this video!", "Jane"));
        // insatiate comments list and add comments for second video
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("I like this video!", "Jack"));
        comments2.Add(new Comment("This video is awesome!", "Jill"));
        // instatiate comments list for third video
        List<Comment> comments3 = new List<Comment>();
        comments3.Add(new Comment("I love this video!", "Jane"));
        comments3.Add(new Comment("This video is awesome!", "Jill"));   
        comments3.Add(new Comment("Great video!", "John"));
        // instatiate comments list for fourth video
        List<Comment> comments4 = new List<Comment>();
        comments4.Add(new Comment("This video is awesome!", "Jill"));
        comments4.Add(new Comment("Great video!", "John"));
        comments4.Add(new Comment("I love this video!", "Jane"));
        
        // insatiate videos list and add videos
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Video 1", "Dmitri Kanyevik", 60, comments1));
        videos.Add(new Video("Video 2", "Muzumbo Omali", 120, comments2));
        videos.Add(new Video("Video 3", "Daniel Radcliff", 180, comments3));
        videos.Add(new Video("Video 4", "Jemeima Makandal", 240, comments4));

        // display comments for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Video: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Duration: " + video.GetDuration() + " seconds");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
        
        Console.WriteLine("\nGoodbye World! This was the YouTubeVideos Project.\n");
    }
}