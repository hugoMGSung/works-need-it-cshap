using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    intList.Add(i);
            //}

            //foreach (var item in intList)
            //{
            //    Console.Write($"{item}, ");
            //}
            //Console.WriteLine();

            //intList.RemoveAt(2);
            //intList.Insert(3, 45);

            //foreach (var item in intList)
            //{
            //    Console.Write($"{item}, ");
            //}
            //Console.WriteLine();

            //Queue<double> q = new Queue<double>();
            //q.Enqueue(11.1);
            //q.Enqueue(22.2);
            //q.Enqueue(33.3);
            //q.Enqueue(44.4);

            //while (q.Count > 0)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 100;
            dic["둘"] = 200;
            dic["셋"] = 300;
            dic["넷"] = 400;

            // Console.WriteLine(dic["하나"]);

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
