using System;

namespace BoxingUnboxing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object a = 20;  // 박싱
            int b = (int)a; // 언박싱
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
