using System;
using System.Collections;

namespace UsingEnumerable
{
    class MyList : IEnumerable
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                }
                array[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        /*
        public object Current {
            get
            {
                return array[position];
            }
        } 

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return true; // (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //while (list.MoveNext())
            //{
            //    Console.WriteLine(list.Current);
            //}
        }
    }
}
