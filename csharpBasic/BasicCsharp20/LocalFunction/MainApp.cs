using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            return new string(arr);

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!!"));
            Console.WriteLine(ToLowerString("MARVEL CINEMATIC UNIVERSE"));
        }
    }
}
