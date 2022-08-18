namespace WpfNaverMovieFinder.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblFavoriteMovies
    {
        public int Idx { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string SubTitle { get; set; }
        public string PubDate { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public string UserRating { get; set; }
        public System.DateTime RegDate { get; set; }
    }
}
