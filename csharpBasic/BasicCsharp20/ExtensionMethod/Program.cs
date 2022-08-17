using System;
using System.Linq;
using System.Text;
using MyExtension;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"2^3 : {2.Power(3)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

            var result = "test".Append('!');
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
