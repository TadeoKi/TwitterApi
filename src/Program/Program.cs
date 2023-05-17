using System;
using System.IO;

namespace TwitterUCU
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new TwitterImage();
            string path = File.Exists(@"../../bill2.jpg") ? @"../../bill2.jpg" : @"bill2.jpg";
            Console.WriteLine(twitter.PublishToTwitter("New Employee 2! ", path));
            var twitterDirectMessage = new TwitterMessage();
            Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "1396065818"));
        }
    }
}