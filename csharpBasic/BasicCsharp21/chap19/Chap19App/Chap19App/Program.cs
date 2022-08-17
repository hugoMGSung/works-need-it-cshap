using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 1/100초동안 멈춤
            }
        }

        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(10); // 1/100초동안 멈춤
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(DoSomething);
            Thread thread1 = new Thread(SomethingHappened);

            try
            {
                Console.WriteLine("스레드 시작!");
                thread.Start();
                thread1.Start();

                thread.Abort();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thread : {i}");
                    Thread.Sleep(10);
                }

                Console.WriteLine("스레드 종료 대기...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료...");
            }
        }
    }
}
