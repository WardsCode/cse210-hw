using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to YouTube channel");
        Console.WriteLine("Here are the videos we selected for you:");
        
       Videos video1 = new Videos();
        video1._author = "Cadmium (feat. Jon Becker)";
        video1._title  = "Melody [Lyric Video]";
        video1._lenght = 210;
        Comments comment1 = new Comments();
        comment1._user1 = "Sweetkisses05";
        comment1.commentsList1.Add("This song reminds me when I was 8! I love it so much!");
        comment1.commentsList1.Add("Who made this song?");
        comment1.commentsList1.Add("Please follow and subcribe");
    

        Videos video2 = new Videos();
        video2._author = " Ms.OOJA ";
        video2._title  = "Nightcore - Miss U";
        video2._lenght = 223;
        Comments comment2 = new Comments();
        comment2._user2 = "Imtired3000killator";
        comment1.commentsList2.Add("Is this inglish? because I believe in life after love.");
        comment1.commentsList2.Add("I hate this song!");
        comment1.commentsList2.Add("I once met this artist!");



        Videos video3 = new Videos();
        video3._author = "| Kabir Singh |";
        video3._title  = "Full Song: Pehla Pyaar";
        video3._lenght = 208;
        Comments comment3 = new Comments();
        comment3._user3 = "HowImeetoyourmotherfan101";
        comment1.commentsList3.Add("Like if you are listening this in 2023");
        comment1.commentsList3.Add("ALhab pghieth khi nahaed!");
        comment1.commentsList3.Add("Who wrote this comments?!");


        
        List<Videos> videoList = new List<Videos> ();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        int counter = 0;
        foreach(Videos video in videoList)
        {
            video.Display(counter);
            counter ++;
        }

        Console.WriteLine("");
        Console.WriteLine("Please choose a video # to see the comments");
        string videoNumber = Console.ReadLine();

        if (videoNumber == "0" )
        {
            comment1.Display1();
        }
        else if (videoNumber == "1" )
        {
            comment1.Display2();
        }
        else if (videoNumber == "2" )
        {
          comment1.Display3();   
        }


        Console.ReadLine();


    }
}