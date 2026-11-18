using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Monstera Deliciosa Care Guide", "Tropical Jungle Home", 745);
        video1.AddComment(new Comment("PlantMom_Jen", "Moving mine closer to the window finally gave me big split leaves!"));
        video1.AddComment(new Comment("GreenThumb99", "What kind of chunky soil mix do you recommend for drainage?"));
        video1.AddComment(new Comment("CarlosG", "Adding a moss pole changed everything for my Monstera."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Keep Calatheas Alive", "The Leafy Corner", 520);
        video2.AddComment(new Comment("FernLover", "Switching from tap water to distilled water saved my Calathea Orbifolia!"));
        video2.AddComment(new Comment("MayaT", "Thank you for explaining the humidity requirements so clearly."));
        video2.AddComment(new Comment("IndoorBotanist", "Do you run your humidifier all day or just for a few hours?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Philodendron Gloriosum Care", "Velvet Leaf Collective", 815);
        video3.AddComment(new Comment("AroidAddict", "Switching to a long rectangular planter made such a huge difference for its crawling stem!"));
        video3.AddComment(new Comment("Sofi_Grows", "How do you keep spider mites off those gorgeous velvety leaves?"));
        video3.AddComment(new Comment("BotanicalBen", "Great reminder not to bury the rhizome too deep in the soil."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._name}: \"{comment._text}\"");
            }
        }
        Console.WriteLine("--------------------------------------------------");
    }
}