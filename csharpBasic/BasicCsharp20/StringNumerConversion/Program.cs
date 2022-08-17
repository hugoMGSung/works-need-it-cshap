using System;

namespace StringNumerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIXVAL = 20;

            object trans = FIXVAL;
            
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b = {b}");
            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine($"d = {d}");

            string e = "123456*";
            int f; 
            if (int.TryParse(e, out f))
            {
                Console.WriteLine($"f = {f}");
            }
            else
            {
                Console.WriteLine("f 변환시 에러발생, 문자열 확인요망");
            }
            //Console.WriteLine($"result = {result}");
            string g = "3:141592";
            float h;
            if (float.TryParse(g, out h))
            {
                Console.WriteLine($"h = {h}");
            }
            else
            {
                Console.WriteLine("g 변환시 에러발생, 문자열 확인요망");
            }
            
        }
    }
}
