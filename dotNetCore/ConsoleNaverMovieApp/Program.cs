using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleNaverMovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientID = "ides3K7kXxmna11Vi4wX";
            string clientSecret = "JAd4Qrrcqp";
            string search = "StarWars";
            string openApiUrl = $"https://openapi.naver.com/v1/search/movie?query={search}";

            string responseJSON = GetRequestResult(openApiUrl, clientID, clientSecret);

            var parseJSON = JObject.Parse(responseJSON);

            var queryResultCount = Convert.ToInt32(parseJSON["display"]); //검색된 검색 결과의 개수
            var totalResultCount = Convert.ToInt32(parseJSON["total"]); //검색 결과 문서의 총 개수

            //개별 검색 결과
            var movieTitle = parseJSON["items"][0]["title"].ToString();
            var movieDirector = parseJSON["items"][0]["director"].ToString();
            var movieActor = parseJSON["items"][0]["actor"].ToString();
            var movieRating = parseJSON["items"][0]["userRating"].ToString();

            Console.WriteLine($"{movieTitle} / {movieDirector} / {movieActor} / {movieRating}");
        }

        private static string GetRequestResult(string openApiUrl, string clientId, string clientSecret)
        {
            var requestResult = string.Empty;

            try
            {
                WebRequest request = null;

                request = WebRequest.Create(openApiUrl);

                request.Headers.Add("X-Naver-Client-Id", clientId);
                request.Headers.Add("X-Naver-Client-Secret", clientSecret);

                Stream dataStream = null;

                var response = request.GetResponse();
                dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                requestResult = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception occurred!");
            }

            return requestResult;
        }
    }
}
