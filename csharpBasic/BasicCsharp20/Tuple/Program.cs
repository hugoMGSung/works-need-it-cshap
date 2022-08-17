using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = ("슈퍼맨", 56, "크립톤");
            //Console.WriteLine($"{a.Item1}, {a.Item2}, {a.Item3}");
            //Console.WriteLine($"{a.Item1.GetType()}, {a.Item2.GetType()}, {a.Item3.GetType()}");

            //var b = (Name: "성명건", Age: 44, Home: "창원");
            //Console.WriteLine($"{b.Age}, {b.Name}, {b.Home}");
            //b = a;
            //Console.WriteLine($"{b.Age}, {b.Name}, {b.Home}");

            var (name, age, home) = GetInfos();
            Console.WriteLine($"{name}, {age}, {home}");
        }

        static Tuple<string, int, string> GetInfo()
        {
            return new Tuple<string, int, string>("성명건", 44, "창원");            
        }

        static (string, int, string) GetInfos()
        {
            return ("성명건", 44, "창원");
        }
    }
}
