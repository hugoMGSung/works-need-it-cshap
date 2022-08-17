using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArray
{
    class Program
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void Main()
        {
            int[] source = { 1, 3, 5, 7, 9 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);
            foreach (var item in target)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            string[] source2 = { "삼", "육", "구" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);
            foreach (var item in target2)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
