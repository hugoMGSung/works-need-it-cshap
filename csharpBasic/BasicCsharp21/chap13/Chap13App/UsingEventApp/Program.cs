using System;

namespace UsingEventApp
{
    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을때 실행되는 메서드(이벤트 핸들러)
        /// </summary>
        /// <param name="message"></param>
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); // 이벤트를 내가만든 로직이 있는 메서드랑 연결

            for (int i = 1; i <= 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
