namespace WpfKakaoNetApp
{
    public class MyLocale
    {
        internal string Name
        {
            get;
            private set;
        }
        internal double Lat
        {
            get;
            private set;
        }
        internal double Lng
        {
            get;
            private set;
        }
        internal MyLocale(string name, double lat, double lng)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
