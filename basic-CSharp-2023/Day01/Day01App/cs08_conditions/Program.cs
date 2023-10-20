using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs08_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            string result = "";
            if (a == 30)
            {
                result = "삼십";
            } else
            {
                result = "삼십아님";
            }

            // 조건 연산자 = 삼항 연산자
            int b = 40;
            string result2 = b == 40 ? "사십" : "사십아님";
        }
    }
}
