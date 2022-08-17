using System;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수할당

                if (line == "quit") break; // quit 입력하면 프로그램 종료.

                int number = 0;
                int.TryParse(line, out number); // int.Parse(line);
                // todo 아래로직을 수정하세요
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");
                }
                else
                {
                    Console.WriteLine("0보다 작은수");
                }
                // todo 마지막
            }

            Console.WriteLine("계산종료!");
        }
    }
}
