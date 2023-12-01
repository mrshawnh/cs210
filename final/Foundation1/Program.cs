using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("PALAGI (Wedding Version)", "TJ Monterde", 235);

        Comments comment1 = new Comments("rhonaleerevestido882","The intro -");
        Comments comment2 = new Comments("jensensenjen6370","ang saya siguro mapag-alayan nang kantang eto");
        Comments comment3 = new Comments("Someone-qh3yl","Groom na lang kulang HAHAHAHA");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        videoList.Add(video1);

        Video video2 = new Video("Forest Blakk - I Choose You (Official Lyric Video)", "Forest Blakk", 177);

        comment1 = new Comments("brittanymckay","I really hope to use this as my wedding song eventually.");
        comment2 = new Comments("hannah_Melissa","Everything he writes is love.. it’s beyond beautiful or gold.. it’s just pure soul bearing love");
        comment3 = new Comments("mister_12.01","Amazing as always.  Great lyrics");

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);

        videoList.Add(video2);

        Video video3 = new Video("Simple Plan - Perfect (Official Video) [HD]", "SimplePlan", 274);

        comment1 = new Comments("zacarshad262","As a teenager you enjoy the music, as an adult you listen to the words.");
        comment2 = new Comments("user-gm4if3kt3u","21 years later and this song still hits the heart strings");
        comment3 = new Comments("user-zq2ii2kd4v","Who miss this times? This type of music, what a nostalgia!");

        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);

        videoList.Add(video3);

        Video video4 = new Video("Daughtry - Home (Official Video)", "Daughtry", 256);

        comment1 = new Comments("arimakanachaaan","it's 2023 and i still love this song. gives me so much feels.");
        comment2 = new Comments("yvngrogel7337","This song still gives me goosebumps <3");
        comment3 = new Comments("matthewidrownthefishybeam7714","Hearing this song live gives me goosebumps all the time when I go to see Daughtry in concert");


        video4.AddComment(comment1);
        video4.AddComment(comment2);
        video4.AddComment(comment3);

        videoList.Add(video4);

        foreach (Video video in videoList){
            video.VideoInformation();
            video.ShowComments();
            Console.WriteLine();
        }

        
    }
}