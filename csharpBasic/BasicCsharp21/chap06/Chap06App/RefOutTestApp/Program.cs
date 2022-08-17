using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            Divide(a, b, ref val, ref rem);

            Console.WriteLine($"{a}, {b} : a/b = {val}, a%b = {rem}");

            bool isSucceed = int.TryParse("1000.74", out int result);
            Console.WriteLine($"변환결과 {isSucceed}, result값 {result}");
        }

        static void Divide(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;

            return;
        }
    }
}
