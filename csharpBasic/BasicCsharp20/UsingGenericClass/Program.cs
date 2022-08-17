using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericClass
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array resized {index}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "abc";
            strList[1] = "def";
            strList[2] = "ghi";
            strList[3] = "jkl";

            //for (int i = 0; i < strList.Length; i++)
            //{
            //    Console.WriteLine(strList[i]);
            //}
            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            MyList<float> floatList = new MyList<float>();
            floatList[0] = 12.4f;
            floatList[1] = 3.141592f;
            floatList[2] = 6.98f;
            floatList[3] = 7.423f;

            //for (int i = 0; i < floatList.Length; i++)
            //{
            //    Console.WriteLine(floatList[i]);
            //}
            foreach (var item in floatList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
