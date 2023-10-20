using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산자  << == *2 / >> == /2 
            int firstval = 15;  // 15 = 0x1111
            int secondval = firstval << 1; // 0x11110 => 16 + 8 + 4 + 2 = 30
            Console.WriteLine(secondval);

            // 1111 & 1101 => 1101  15 & 13 => 13
            // 1010 | 0101 => 1111
            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval); // XOR
            Console.WriteLine(~secondval); // 보수
            // 실무에서는 많이 안씀

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null ? 0 : checkval); // 3항연산자
            Console.WriteLine(checkval ?? 0); // null병합연산자는 3항연산자를 더 축소

            checkval = 25;
            Console.WriteLine(checkval.HasValue ? checkval.Value : 0);
            Console.WriteLine(checkval ?? 0);
        }
    }
}
