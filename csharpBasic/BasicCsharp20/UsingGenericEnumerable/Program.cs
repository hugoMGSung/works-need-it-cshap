using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericEnumerable
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] array;
        private int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public int Length
        {
            get { return array.Length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array resize {index}");
                }
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "abc";
            strList[1] = "cde";
            strList[2] = "def";
            strList[3] = "efg";

            foreach (var item in strList)
            {
                Console.Write($"'{item}' ,");
            }
            Console.WriteLine();
        }
    }
}
