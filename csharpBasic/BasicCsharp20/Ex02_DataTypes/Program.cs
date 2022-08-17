using System;

namespace Ex02_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = true;
            byte bt = 255;  // MaxValue
            sbyte sbt = -128;  // MinValue
            short st = 32767;  // MaxValue
            ushort ust = 65535;  
            int it = 2147483647; 
            uint uit = 4294967295; 
            long ln = -9223372036854775808l; // MinValue
            ulong uln = 18446744073709551615l;  // MaxValue

            float fl = 3.40282347E+38F; 
            double dbl = 1.7976931348623157E+308;
            decimal dcm = 79228162514264337593543950335M; 

            char c = 'A'; // 65
            string s = "Hello";

            DateTime dt = DateTime.Now;

            int? ni = null;
        }
    }
}
