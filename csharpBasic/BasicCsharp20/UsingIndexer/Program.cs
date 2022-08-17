using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIndexer
{
    class MyList
    {
        public int[] array;

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
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            list[3] = 4;
            list[4] = 5;

            foreach (var item in list.array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
