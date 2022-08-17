using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    class Mathz
    {
        // 여러 행위(기능 : 메서드) 들이 많다...
        public int Plus(int a, int b)
        {
            // ...
            return 1;
        }

        public static void PrintEven(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine($" 값: {val}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ...

            Mathz mathz = new Mathz();

            int x;

            // ...
            x = 5;
            mathz.Plus(x, 6);

            /*if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            Mathz.PrintEven(x);

            // ...

            x = 10;
            /*if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            Mathz.PrintEven(x);

            // ...
        }
    }
}
