using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfMovieFinder.Helpers
{
    internal class Commons
    {
        public static string CONNSTRING { get; set; }

        public static string APIKEYURLSTRING { get; set; }

        public static string GetRestApiUrl(string name)
        {
            var url = $"{APIKEYURLSTRING}&t={name}";
            return url;
        }

        public static string GetRestApiUrl(string name, string year)
        {
            var url = $"{APIKEYURLSTRING}&t={name}&y={year}";
            return url;
        }

        public static bool IsNumeric(string source)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(source);
        }

        public static byte[] ImageSourceToBytes(ImageSource imageSource)
        {
            byte[] bytes = null;
            var bitmapSource = imageSource as BitmapSource;

            if (bitmapSource != null)
            {
                var encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    bytes = stream.ToArray();
                }
            }

            return bytes;
        }
    }
}
