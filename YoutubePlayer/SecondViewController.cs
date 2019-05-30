using System;

using UIKit;

using CloudRailSI;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using System.Collections.Generic;

namespace YoutubePlayer
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


    }

    partial void SearchButton_TouchUpInside(UIButton sender)
    {
        Text1.ResignFirstResponder();
        string search = Text1.Text;
            //bool Loaded = Video2.LoadWithVideoId(VidId);
            //if(Loaded == false)
            //{
            //    Text1.Text = "Invalid Video ID";
            //}

            //var youtube = new CRYouTube("AIzaSyAO3XbE69COpcBy5RcYx1fB-EowFqm6OTY");
            //youtube.Login();

            //var results = youtube.SearchVideosWithQuery(search, 0, 5);

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyAO3XbE69COpcBy5RcYx1fB-EowFqm6OTY",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = "SpongeBob"; // Replace with your search term.
            searchListRequest.MaxResults = 5;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();

            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                        break;

                    case "youtube#channel":
                        channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        break;

                    case "youtube#playlist":
                        playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }
            }

            Console.WriteLine(String.Format("Videos:\n{0}\n", string.Join("\n", videos)));
            Console.WriteLine(String.Format("Channels:\n{0}\n", string.Join("\n", channels)));
            Console.WriteLine(String.Format("Playlists:\n{0}\n", string.Join("\n", playlists)));

            SearchResults.Text = String.Format("Videos:\n{0}\n", string.Join("\n", videos));


        }




        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

