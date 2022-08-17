using System;

namespace KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 100, y = 0;

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                y = 2;
                Console.WriteLine($"{x / y}");

                string origin = "RR";
                int val = int.Parse(origin);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"딴예외발생 : {ex.Message}");
                Console.WriteLine($"소스중에 0으로 된 변수 잘 확인하세요. 쫌~");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"난 몰라 : {ex.Message}");
            }
        }
    }
}
