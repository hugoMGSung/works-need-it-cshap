using System;
using System.Threading;

namespace thread01_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().DoThreadTest();
        }

        internal void DoThreadTest()
        {
            Thread th = new Thread(new ThreadStart(Run));
            th.Start();
            Run();
        }

        internal void Run()
        {
            Console.WriteLine($"스레드 {Thread.CurrentThread.ManagedThreadId}번 시작!");
            Thread.Sleep(3000);  // 스레드 대신 뭔가를 할 것
            Console.WriteLine($"스레드 {Thread.CurrentThread.ManagedThreadId}번 종료!!");
        }
    }
}
