using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to Programming", "CodeMaster", 600);
        Video video2 = new Video("Web Development Basics", "WebWizard", 480);
        Video video3 = new Video("Machine Learning Fundamentals", "AIDreamer", 720);
        Video video4 = new Video("Digital Art Techniques", "ArtCreator", 300);

        video1.addComment("JohnDoe", "Great video!");
        video1.addComment("Alice123", "Very informative.");
        video1.addComment("BobSmith", "Looking forward to more content.");
        video1.addComment("Eve", "Helped me a lot, thanks!");

        video2.addComment("WebLearner", "Nice explanation of concepts.");
        video2.addComment("CodingEnthusiast", "Clear and concise.");
        video2.addComment("WebDevFanatic", "Keep up the good work!");
        video2.addComment("LearningLover", "I learned a lot from this video.");

        video3.addComment("MLNewbie", "Amazing introduction to ML.");
        video3.addComment("DataScienceFan", "Looking forward to advanced topics.");
        video3.addComment("AIExplorer", "Well explained concepts.");
        video3.addComment("TechSavvy", "This is exactly what I was looking for.");

        video4.addComment("DigitalArtFan", "Great techniques for digital art.");
        video4.addComment("CreativeMind", "Inspiring and creative ideas.");
        video4.addComment("ArtisticSoul", "I tried this and it worked wonders.");
        video4.addComment("ArtLover123", "Looking forward to more art tutorials.");

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach(Video video in videos){
            Console.WriteLine();
            Console.WriteLine($"{video.getVideoDetails()} has the following comments:");
            List<Comment> comments = video.GetComments();
            foreach(Comment comment in comments){
                Console.WriteLine(comment.getCommentInfo());
            }
        }
    }
}