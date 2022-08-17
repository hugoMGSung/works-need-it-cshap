using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newcopy = new MyClass
            {
                MyField1 = this.MyField1,
                MyField2 = this.MyField2
            };
            return newcopy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };
                MyClass target = source;
                target.MyField2 = 300;
                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };
                MyClass target = source.DeepCopy();
                target.MyField2 = 300;
                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
