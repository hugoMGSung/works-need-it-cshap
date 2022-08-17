using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string input = "Zbcdefg";
            string result = s.solution(input);
            Console.WriteLine(input);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            char[] charArray = s.ToCharArray();
            System.Array.Reverse(charArray);
            answer = new string(charArray);
            return answer;
        }
    }
}
