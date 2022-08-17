using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList list = new ArrayList();
            ArrayList list = new ArrayList { 123, 456, 789 }; 
            for (int i = 0; i < 10; i++)
            {
                int iresult = list.Add(i); // 리스트 맨마지막 추가
                Console.WriteLine($"{iresult}번째에 데이터 {i}추가완료");
            }

            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.RemoveAt(2); // 인덱스위치값 삭제

            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.Insert(4, 4.5); // 인덱스위치에 값을 추가

            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.Clear(); // 전체 삭제
            Console.WriteLine("After Clear()");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
