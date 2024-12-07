using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Understanding Abastraction", "John Foster", 300);
        Video video2 = new Video("Learning Programming with Classes", "Sarah Connor", 450);
        Video video3 = new Video("Advanced C#", "Fred Hawkins", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Person1", "Great explanation!"));
        video1.AddComment(new Comment("Person2", "Very helpful, thank you!"));
        video1.AddComment(new Comment("Person3", "Great video"));

        // Add comments to video2
        video2.AddComment(new Comment("User1", "Awwesome tutorial!"));
        video2.AddComment(new Comment("User2", "Great content!"));
        video2.AddComment(new Comment("User3", "This is insightful"));

        // Add comments to video3
        video3.AddComment(new Comment("Subscriber1", "Exactly what i needed"));
        video3.AddComment(new Comment("Subscriber2", "So clear and concise!"));
        video3.AddComment(new Comment("Subscriber3", "Simple enough to learn from"));

        // Add videos to a list
        List<Video> videos = new List<Video> {video1, video2, video3};

        // Display infromation for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine(new string('-', 40));
        }
    }
}