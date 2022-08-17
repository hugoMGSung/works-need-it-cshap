using System;
using System.Collections;

namespace UsingHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["이름"] = "성명건";
            ht["주소"] = "부산광역시 해운대구";
            ht["전번"] = "010-7625-0675";
            ht["키"] = 179.0;
            ht["결혼여부"] = true;

            Console.WriteLine($"{ht["결혼여부"]}");
        }
    }
}
