using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfMovieFinder.Helpers;
using WpfMovieFinder.Models;

namespace WpfMovieFinder.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            ClearControls();
        }

        private void ClearControls()
        {
            TxbTitle.Text = TxbYear.Text = TxbRunTime.Text = TxbRated.Text = TxbPlot.Text = string.Empty;
            TxbGenre.Text = TxbActors.Text = TxbMetaScore.Text = string.Empty;
            ImgPoster.Source = null;

            MovieName.Text = ReleaseYear.Text = string.Empty;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchMovie();
        }

        private void SearchMovie()
        {
            if (string.IsNullOrEmpty(MovieName.Text) && string.IsNullOrEmpty(ReleaseYear.Text))
            {
                CustomPopupView cmsg = new CustomPopupView("영화제목을 입력하세요~");
                cmsg.Owner = this;
                cmsg.ShowDialog();
                return;
            }

            // TODO
            string apiUrl = string.Empty;
            if (string.IsNullOrEmpty(ReleaseYear.Text))
                apiUrl = Commons.GetRestApiUrl(MovieName.Text.Trim());
            else
                apiUrl = Commons.GetRestApiUrl(MovieName.Text.Trim(), ReleaseYear.Text.Trim());

            using (WebClient wc = new WebClient { Encoding = Encoding.UTF8 })
            {
                var json = wc.DownloadString(apiUrl);
                var result = JsonConvert.DeserializeObject<MovieEntity>(json);

                if (result.Response == "True")
                {
                    TxbTitle.Text = result.Title;
                    TxbYear.Text = result.Year;
                    TxbRated.Text = result.imdbRating;
                    TxbRunTime.Text = result.Runtime;
                    TxbGenre.Text = result.Genre;
                    TxbActors.Text = result.Actors;
                    TxbPlot.Text = result.Plot;
                    TxbMetaScore.Text = result.Metascore;

                    HiddenPosterUrl.Text = result.Poster;

                    if (result.Poster != "N/A")
                    {
                        try
                        {
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(result.Poster, UriKind.Absolute);
                            bitmap.EndInit();

                            ImgPoster.Source = bitmap;
                        }
                        catch (Exception)
                        {
                            ImgPoster.Source = null;
                        }
                    }
                    else
                    {
                        ImgPoster.Source = null;
                    }
                }
                else
                {
                    CustomPopupView cmsg = new CustomPopupView("찾는 영화가 없습니다!!");
                    cmsg.Owner = this;
                    cmsg.ShowDialog();
                    return;
                }
            }
        }

        private void ReleaseYear_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !Commons.IsNumeric(e.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();
        }

        private void WatchTrailer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(MovieName.Text) && string.IsNullOrEmpty(ReleaseYear.Text))
            {
                CustomPopupView cmsg = new CustomPopupView("영화제목을 입력하세요~");
                cmsg.Owner = this;
                cmsg.ShowDialog();
                return;
            }

            MovieTrailerView mview = new MovieTrailerView(TxbTitle.Text.Trim());
            mview.Owner = this;
            mview.ShowDialog();
            return;
        }

        private void MovieName_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SearchMovie();
            }
        }

        private void AddWatchList_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxbTitle.Text) && string.IsNullOrEmpty(TxbYear.Text) && string.IsNullOrEmpty(TxbRated.Text)
                && string.IsNullOrEmpty(TxbRunTime.Text) && string.IsNullOrEmpty(TxbGenre.Text) && string.IsNullOrEmpty(TxbActors.Text)
                && string.IsNullOrEmpty(TxbPlot.Text) && string.IsNullOrEmpty(TxbMetaScore.Text) 
                && ImgPoster.Source == null)
            {
                CustomPopupView cmsg = new CustomPopupView("필드가 비면 안됩니다~");
                cmsg.Owner = this;
                cmsg.ShowDialog();
                return;
            }

            ImageSource image = ImgPoster.Source;
            byte[] arr = Commons.ImageSourceToBytes(image);

            MovieEntity param = new MovieEntity()
            {
                Title = TxbTitle.Text,
                Year = TxbYear.Text,
                Rated = TxbRated.Text,
                Runtime = TxbRunTime.Text,
                Genre = TxbGenre.Text,
                Actors = TxbActors.Text,
                Plot = TxbPlot.Text,
                Metascore = TxbMetaScore.Text,
                Poster = HiddenPosterUrl.Text,
                Picture = arr,
                Trailer = "" //TrailerUrl()
            };

            DAL.SetWatchMovie(param);
        }
    }
}
