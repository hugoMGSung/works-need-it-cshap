using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using wp11_movieFinder.Models;

namespace wp11_movieFinder
{
    /// <summary>
    /// TrailerWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TrailerWindow : MetroWindow
    {
        List<YoutubeItem> youtubeItems = null; // 검색결과 담을 리스트

        public TrailerWindow()
        {
            InitializeComponent();
        }

        // 부모에서 데이터를 가져올려면 재정의생성자
        public TrailerWindow(string movieName) : this()
        {
            LblMovieName.Content = $"{movieName} 예고편";
        }

        // 부모에서 객체를 통채로 전달받을 수도 있음
        public TrailerWindow(MovieItem movie) : this()
        {
            LblMovieName.Content = $"{movie.Title} 예고편";
        }

        // 화면 로드 완료후에 YoutubeAPI 실행
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            youtubeItems = new List<YoutubeItem>(); //초기화
            SearchYoutubeApi();
        }

        private async void SearchYoutubeApi()
        {
            await LoadDataCollection();
            LsvResult.ItemsSource = youtubeItems; // direct binding
        }

        private async Task LoadDataCollection()
        {
            var youtubeService = new YouTubeService(
                new BaseClientService.Initializer()
                {
                    ApiKey = "My유튜브키",
                    ApplicationName = this.GetType().ToString()
                });

            var req = youtubeService.Search.List("snippet");
            req.Q = LblMovieName.Content.ToString();
            req.MaxResults = 10;

            var res = await req.ExecuteAsync(); // 검색결과를 받아옴

            Debug.WriteLine("유튜브 검색결과 ------");
            foreach (var item in res.Items)
            {                
                Debug.WriteLine(item.Snippet.Title);
                if (item.Id.Kind.Equals("youtube#video")) // youtube#video 만 동영상 플레이 가능
                {
                    YoutubeItem youtube = new YoutubeItem()
                    {
                        Title = item.Snippet.Title,
                        ChannelTitle = item.Snippet.ChannelTitle,
                        URL = $"https://www.youtube.com/watch?v={item.Id.VideoId}", // 유튜브플레이 링크
                        // Author = item.Snippet.ChannelTitle
                    };

                    youtube.Thumbnail = new BitmapImage(new Uri(item.Snippet.Thumbnails.Default__.Url,
                                                        UriKind.RelativeOrAbsolute));
                    youtubeItems.Add(youtube);
                }
            }
        }

        private void LsvResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LsvResult.SelectedItem is YoutubeItem)
            {
                var video = LsvResult.SelectedItem as YoutubeItem;
                BrsYoutube.Address = video.URL;
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BrsYoutube.Address = string.Empty; // 웹브라우저 주소 클리어
            BrsYoutube.Dispose(); // 리소스 해제(!)
        }
    }
}
