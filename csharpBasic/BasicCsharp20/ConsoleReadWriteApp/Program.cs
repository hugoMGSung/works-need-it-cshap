using System;

namespace ConsoleReadWriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("이름 입력 : ");

            string name = Console.ReadLine(); // 입력
            Console.WriteLine($"안녕하세요, {name} 님!");
        }
    }
}
