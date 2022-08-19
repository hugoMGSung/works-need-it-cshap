using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfMovieFinder.Models;

namespace WpfMovieFinder.Views
{
    /// <summary>
    /// MovieTrailerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MovieTrailerView : MetroWindow
    {
        public List<YoutubeEntity> videos;

        public MovieTrailerView()
        {
            InitializeComponent();
        }

        public MovieTrailerView(string movieName) : this()
        {
            MovieName.Text = $"{movieName} official trailer";

            StartSearch();
            
        }

        private async void StartSearch()
        {
            await LoadDataCollection();
            YoutubeSearchDisplay.ItemsSource = videos;
        }

        private async Task LoadDataCollection()
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCXib5-Wu2HGVttwoGn5E5QTp1nS37fw6o",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = MovieName.Text;
            searchListRequest.MaxResults = 10;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            videos = new List<YoutubeEntity>();

            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        YoutubeEntity video = new YoutubeEntity();
                        video.Title = searchResult.Snippet.Title;
                        video.Author = searchResult.Snippet.ChannelTitle;
                        video.URL = $"https://www.youtube.com/watch?v={searchResult.Id.VideoId}";
                        byte[] imageBytes = new WebClient().DownloadData(searchResult.Snippet.Thumbnails.Default__.Url);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            var imageSource = new BitmapImage();
                            imageSource.BeginInit();
                            imageSource.StreamSource = ms;
                            imageSource.EndInit();

                            // Assign the Source property of your image
                            video.Thumbnail = new Image { Source = imageSource };
                        }
                        videos.Add(video);
                        break;
                }
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            YoutubeEntity video = (YoutubeEntity)YoutubeSearchDisplay.SelectedItem;

            if (video == null) return;

            //Process.Start(video.URL);
            YoutubeWatch.Source = new Uri(video.URL);
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            YoutubeWatch.Source = null;
        }
    }
}
