using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs28_event
{
    // 이벤트를 사용하려면
    // 1. 대리자를 생성
    delegate void EventHandler(string message);

    class CustomNotifier
    {
        // 2. 이벤트를 준비(대리자를 사용한)
        public event EventHandler SomethingChanged;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                // 3. 특별한 이벤트가 발생할 상황에서 이벤트를 수행
                SomethingChanged(string.Format("{0} : odd", number));
            }
        }
    }

    internal class Program
    {
        // 4. 이벤트가 대신 호출할 메서드
        static void CustomHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingChanged += new EventHandler(CustomHandler);

            for (int i = 0; i <= 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
