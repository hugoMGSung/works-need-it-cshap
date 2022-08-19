using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NaverMovieFinder
{
    public class Movie
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string SubTitle { get; set; }
        public string PubDate { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public double UserRating { get; set; }
    }

    public class NaverMovieModel
    {
        public List<Movie> AllMovies { get; private set; }

        public NaverMovieModel()
        {
            AllMovies = new List<Movie>();
        }

        public event EventHandler OnMovieLoadCompleted;
        public void SearchMovie(string keyword)
        {
            string url = "https://openapi.naver.com/v1/search/movie?key=ides3K7kXxmna11Vi4wX&query=" + keyword + "&display=10&start=1";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            foreach (XmlNode xmlNode
                in xmlDoc.SelectNodes("//rss/channel/item"))
            {
                string title = xmlNode["title"].InnerText;
                string link = xmlNode["link"].InnerText;
                string image = xmlNode["image"].InnerText;
                string subTitle = xmlNode["subtitle"].InnerText;
                string pubDate = xmlNode["pubDate"].InnerText;
                string director = xmlNode["director"].InnerText;
                string actor = xmlNode["actor"].InnerText;
                string userRating = xmlNode["userRating"].InnerText;

                this.AllMovies.Add(new Movie()
                {
                    Title = title,
                    Link = link,
                    Image = image,
                    SubTitle = subTitle,
                    PubDate = pubDate,
                    Director = director,
                    Actor = actor,
                    UserRating = double.Parse(userRating)
                });
            }

            if (OnMovieLoadCompleted != null)
            {
                this.OnMovieLoadCompleted(this, new EventArgs());
            }
        }
    }
}
