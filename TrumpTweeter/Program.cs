using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using HtmlAgilityPack;

// Objective: Scrape memes/images from r/The_Donald
// and create tweets out of them to send from the
// TrumpTweeterBot account with relevant hashtags
// and hopefully funny text.

namespace TrumpTweeter
{
    // A class for publicly accessible variables

    public static class Globals
    {
        public static string consumerKey = "";
        public static string consumerSecret = "";
        public static string accessToken = "";
        public static string accessTokenSecret = "";

        public static string url = @"https://www.reddit.com/r/The_Donald/new/";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
        }

        // A nice greeting as well as a central place
        // to call all our methods.

        static void Greeting()
        {
            Console.WriteLine("Hello and welcome to the TrumpTweeter 9000!");
            Console.WriteLine("Let's get started. Beep boop boop...");

            // User authentication happens
            //UserAuthentication();

            ConnectToReddit();
            Console.ReadKey();
        }

        // Twitter account authentication happens here

        static void UserAuthentication()
        {
            string consumerKey = Globals.consumerKey;
            string consumerSecret = Globals.consumerSecret;
            string accessToken = Globals.accessToken;
            string accessTokenSecret = Globals.accessTokenSecret;

            Auth.SetUserCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);

            // Here we'll call the reddit connection 
            // method and once connected we call the
            // images/memes scraper
            // Once something has been scraped the
            // tweet will be tweeted

            ConnectToReddit();
        }

        // We'll use this method to connect to the
        // r/The_Donald subreddit and then call the
        // ScrapeImage method

        static void ConnectToReddit()
        {
            string url = Globals.url;
            HtmlDocument doc = new HtmlWeb().Load(url);
            ScrapeImage(doc);
        }

        // We'll use this method to scrape images/memes
        // from r/The_Donald and then call the CreateTweet
        // method

        static void ScrapeImage(HtmlDocument doc)
        {     
            var imagesAndMemesUrl = doc.DocumentNode.SelectNodes("//p[@class='title']/a").ToArray();
            
            foreach (var imageAndMemeUrl in imagesAndMemesUrl)
            {
                Console.WriteLine(imageAndMemeUrl.InnerText);
                Console.WriteLine(imageAndMemeUrl.Attributes["href"].Value);
                Console.WriteLine();
            }
            Console.ReadKey();

            // CreateTweet();
        }

        // We'll pass in the scraped images/memes so
        // this method can build our tweet and then
        // call the PublishTweet method

        static void CreateTweet()
        {
            PublishTweet();
        }

        // This method will handle the publishing of
        // the tweets

        static void PublishTweet()
        {
            Tweet.PublishTweet("Hello world!");
        }
    }
}
