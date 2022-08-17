using System;
using System.Globalization;
using static System.Console;

namespace StringSearchApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string g = "Good Morning";
            //WriteLine(g);

            //WriteLine($"IndexOf 'Good' : {g.IndexOf("Good")}");
            //WriteLine($"LastIndexOf 'Good' : {g.LastIndexOf("Good")}");

            //WriteLine($"IndexOf 'n' : {g.IndexOf('n')}");
            //WriteLine($"LastIndexOf 'n' : {g.LastIndexOf('n')}");
            //// StartsWith
            //WriteLine($"StartsWith 'Good' : {g.StartsWith("Good")}");
            //WriteLine($"StartsWith 'Morning' : {g.StartsWith("Morning")}");
            //// Contains
            //WriteLine($"Contains 'Good' : {g.Contains("Good")}");
            //// Replace
            //WriteLine($"Replace 'Morning' to 'Evening' : " +
            //       $"{g.Replace("Morning", "Evening")}");

            //if (g.Contains("Morning"))
            //{
            //    g.Replace("Morning", "Evening");
            //}

            //WriteLine($"ToLower : {g.ToLower()}");
            //WriteLine($"ToUpper : {g.ToUpper()}");
            //WriteLine($"Insert : {g.Insert(g.IndexOf("Morning") - 1, " Very")}");

            //WriteLine($"Remove : '{"I don't Love You".Remove(2, 6)}'");
            //WriteLine($"Trim : '{" No Space ".Trim()}'");
            //WriteLine($"Trim : '{" No Space ".TrimStart()}'");
            //WriteLine($"Trim : '{" No Space ".TrimEnd()}'");
            //string codes = "MSFT,GOOG,AMZN,AAPL, RHT";
            //var result = codes.Split(',');
            //foreach (var item in result)
            //{
            //    WriteLine($"each item '{item.Trim()}'");
            //}
            //WriteLine($"substring : {g.Substring(0, 4)}");
            //WriteLine($"substring : {g.Substring(5)}");

            //WriteLine(string.Format("{0}DEF", "ABC"));
            //WriteLine(string.Format("{0,-10}DEF", "ABC"));
            //WriteLine(string.Format("{0, 10}DEF", "ABC"));

            DateTime dt = DateTime.Now;
            //WriteLine(string.Format($"{dt:yyyy-MM-dd HH:mm:ss}")); // 가장
            //WriteLine(string.Format($"{dt:d/M/yyyy HH:mm:ss}"));
            //WriteLine(string.Format($"{dt:y yy yyy yyyy}"));
            //WriteLine(string.Format($"{dt:M MM MMM MMMM}"));
            //WriteLine(string.Format($"{dt:d dd ddd dddd}"));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));

            decimal mvalue = 27000000m;
            WriteLine(mvalue.ToString("C"));
            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("fr-FR")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));
        }
    }
}

