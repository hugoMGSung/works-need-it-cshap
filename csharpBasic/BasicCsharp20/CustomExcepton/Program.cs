using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcepton
{
    class InvalidArgumentException : Exception
    {
        public object Argument { get; set; }
        public string Range { get; set; }

        public InvalidArgumentException()
        {
        }

        public InvalidArgumentException(string message) : base(message)
        {
            
        }
    }

    class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (var item in args)
            {
                if (item > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = item,
                        Range = "0-255"
                    };
            }

            return (alpha << 24 & 0xFF000000) |
                    (red << 16 & 0x00FF0000) |
                    (green << 8 & 0x0000FF00) |
                    (blue & 0x000000FF);
         }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"0x{MergeARGB(255, 111, 111, 111):X}");
                Console.WriteLine($"0x{MergeARGB(255, 255, 257, 255):X}");
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine($"예외발생 입력범위 : {ex.Range}");
                Console.WriteLine("제대로 좀 넣어라, 인간아!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
