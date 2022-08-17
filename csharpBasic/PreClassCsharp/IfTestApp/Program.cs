using static System.Console;

namespace IfTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Write("입력하세요 : ");
            //    string input = ReadLine();

            //    if (input.ToUpper() == "EXIT")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        for (int i = 0)
            //    }                
            //}

            for (int i = 2; i <= 9; i++)
            {
                WriteLine($"==== 구구단 {i}단 시작 =====");
                for (int j = 1; j <= 9; j++)
                {
                    Write($"{i} x {j} = {i*j} \t");
                }
                WriteLine("");
            }            
        }
    }
}
