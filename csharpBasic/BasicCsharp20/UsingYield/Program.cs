using System;
using System.Collections;

namespace UsingYield
{
    class MyEnumerator : IEnumerable
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
            yield return numbers[4];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}

