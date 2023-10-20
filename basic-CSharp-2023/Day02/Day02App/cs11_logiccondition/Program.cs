using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs11_logiccondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region < If구문 >

            int a = 20;

            if (a == 20) // 처리하는 로직이 있으면 무조건 {} 쓰세요!
            {
                Console.WriteLine("20입니다.");                
            }
            else
            {
                Console.WriteLine("20이 아닙니다.");
            }

            if (a == 30) return; // 메서드를 완전히 빠져나가는 구문은 한줄로 OK

            #endregion

            #region < 데이터타입 비교 Switch구문 >

            // 데이터타입 비교 switch문 (C# 7.0부터 .NET framework 4.7 / 4.8) 
            object obj = null;

            string inputs = Console.ReadLine(); // 콘솔에서 입력
            if (int.TryParse(inputs, out int iouput)) // 예외가 발생하면 0 
            {
                obj = iouput; // 입력값이 정수라서 문자열을 정수 변환
            }
            else if (float.TryParse(inputs, out float foutput))
            {
                obj = foutput; // 입력값이 실수라서 문자열을 실수 변환
            }
            else
            {
                obj = inputs; // 이도 저도 아니다
            }

            Console.WriteLine(obj);
            switch (obj)
            {
                case int i: // 정수라면
                    Console.WriteLine("{0}는 int 형식입니다.", i);
                    break;
                case float f: // 실수라면
                    Console.WriteLine("{0}는 float 형식입니다.", f);
                    break;
                case string s: // 문자열이면
                    Console.WriteLine("{0}는 string 형식입니다." , s);
                    break;
                default:
                    Console.WriteLine("몰라요, 먼 타입인지...");
                    break;
            }

            #endregion

            #region < 2중 For문 - 구구단 >

            for (int x = 2; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
                }
            }

            #endregion

            #region < Foreach문 >

            int[] ary = { 2, 4, 6, 8, 10 }; // 배열이나 컬렉션(리스트)

            foreach (int i in ary) {
                Console.WriteLine("{0}*2 = {1}", i, i*2);
            }
            // 위아래 완전 동일
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("{0}*2 = {1}", ary[i], ary[i] * 2);
            }

            #endregion
        }
    }
}
