using System;
using static System.Console;

namespace HelloWorldApp
{
    internal class HelloWorld
    {
        // 엔트리 포인트
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : HelloWorldApp.exe <이름>");
                return;
            }

            WriteLine($"Hello, {args[0]}");
        }
    }
}
