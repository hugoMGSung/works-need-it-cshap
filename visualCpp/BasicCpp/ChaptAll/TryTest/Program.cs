using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c;

            try
            {
                a = 10;
                b = 0;
                c = a / b;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
