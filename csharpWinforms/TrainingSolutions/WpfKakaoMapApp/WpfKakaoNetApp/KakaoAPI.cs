using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WpfKakaoNetApp
{
    static class KakaoAPI
    {
        internal static List<MyLocale> Search(string query)
        {
            List<MyLocale> mls = new List<MyLocale>();
            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string rquery = string.Format("{0}?query={1}", site, query);
            WebRequest request = WebRequest.Create(rquery);
            string rkey = "1d3365a802a781dea94ddff5572d2cfe";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(lname, y, x));
            }
            return mls;
        }
    }
}
