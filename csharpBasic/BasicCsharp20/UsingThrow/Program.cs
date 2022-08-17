using System;

namespace UsingThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomthing(1);
                DoSomthing(2);
                DoSomthing(9);
                // DoSomthing(12);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine($"도움말링크 : {ex.HelpLink}");
                Console.WriteLine($"소스 : {ex.Source}");
            }
            finally
            {
                Console.WriteLine("에러가 있든없든 수행합니다");
            }
        }

        private static void DoSomthing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다") 
                { 
                    HelpLink = "http://www.google.com",
                    Source = "UsingThrow line 34",
                };
        }
    }
}
