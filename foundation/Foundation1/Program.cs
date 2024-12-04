using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Defying Gravity: Broom Edition", "Elphaba Thropp", 720);
        video1.AddComment(new Comment("Glinda Upland", "You're defying gravity, but your hat defied fashion."));
        video1.AddComment(new Comment("Fiyero Tiggular", "You mean we could've flown away this whole time??"));
        video1.AddComment(new Comment("Madame Morribble", "This display is unacceptable! ... But oddly mesmerizing."));
        videos.Add(video1);

        Video video2 = new Video("Toss, Toss: How to Be Popular in Shiz", "Glinda Upland", 600);
        video2.AddComment(new Comment("Elphaba Thropp", "Hey, I'm still waiting for my ballgown."));
        video2.AddComment(new Comment("Pfannee of Phan Hall", "Step 1: Be Glinda. Step 2: That's it"));
        video2.AddComment(new Comment("Boq aka Biq", "Any tips for munchkins?"));
        video2.AddComment(new Comment("Nessarose Thropp", "Wow Glinda, you embolden me!"));
        videos.Add(video2);

        Video video3 = new Video("Dancing Through Life: Ozdust", "Fiyero Tiggular", 480);
        video3.AddComment(new Comment("Glinda Upland", "You missed the twirl! Always Twirl!"));
        video3.AddComment(new Comment("Elphaba Thropp", "Thanks to you, my dance went viral!"));
        video3.AddComment(new Comment("Boq aka Biq", "How do you get noticed by the most popular girl? Asking for a friend."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}