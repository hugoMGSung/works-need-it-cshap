using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Status
        {
            None, // 0 = 0000
            Ok, // 1 = 0001
            Yes, // 2 = 0010
            No, // 3 = 0011
            Cancel // 4 = 0100
        }
        static void Main(string[] args)
        {
            Status status = Status.None;

            status = Status.Ok;
            Console.WriteLine($"Status ara {status}");

            status |= Status.Cancel;  // 0001 |(and) 0100  
            Console.WriteLine($"Status ara {status}");

        }
    }
}
