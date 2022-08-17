using static System.Console;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MaxValue;
            //byte b = byte.MinValue;

            //short c = short.MinValue;
            //ushort d = ushort.MaxValue;

            //int e = int.MinValue;
            //uint f = uint.MaxValue;

            //long g = long.MaxValue;
            //ulong h = ulong.MaxValue;
            //ulong i = 20_000_000_000;
            //Console.WriteLine(i);

            //byte a = 255;
            //WriteLine($"a = {a}");
            //byte b = 0b1111_1111;
            //WriteLine($"b = {b}");
            //byte c = 0xFF;
            //WriteLine($"c = {c}");

            byte d = byte.MaxValue;
            WriteLine($"d = {d}");
            d += 1;
            WriteLine($"d = {d}");
            d += 1;
            WriteLine($"d = {d}");

            float f = float.MaxValue;
            double g = double.MaxValue;

        }
    }
}
