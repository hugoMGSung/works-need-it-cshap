using System;

namespace IntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MaxValue;
            //Console.WriteLine($"a = {a}");
            //int b = a;
            //Console.WriteLine($"b = {b}");
            //int x = 128;
            //Console.WriteLine($"x = {x}");
            //sbyte y = (sbyte)x; // 오버플로우 발생! 조심!!
            //Console.WriteLine($"y = {y}");

            //double pi = 3.1415926535_8979323846_2643383279_5028841971_6939937510_5820974944_5923078164;
            //Console.WriteLine($"pi = {pi}");
            //float fpi = (float)pi;
            //Console.WriteLine($"fpi = {fpi}");
            double dmax = double.MaxValue;
            Console.WriteLine($"dmax = {dmax}");
            float fmax = (float)dmax;
            Console.WriteLine($"fmax = {fmax}");


        }
    }
}
