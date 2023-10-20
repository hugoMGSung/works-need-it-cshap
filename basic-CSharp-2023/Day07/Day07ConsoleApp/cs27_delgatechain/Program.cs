using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delgatechain
{
    delegate void ThereIsAFire(string location); // 불났을때 대신해주는 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);

    #region < 클래스 Sample 람다식 프로퍼티 >
    class Sample
    {
        private int valueA; // 맴버변수 - 외부에서 접근불가

        //public int ValueA // 프로퍼티
        //{
        //    //get { return valueA; }
        //    //set { valueA = value; }
        //    get => valueA;
        //    set => valueA = value;
        //}
        public int ValueA
        {
            get => valueA; // get은 람다식
            set { 
                valueA = value;  // set 일반식
            }
        }
    }
    #endregion

    internal class Program
    {
        #region < 축소 >
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? {0}에 불났어요!!", location);
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine("{0}에 불났어요!", location);
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다.", location);
        }

        #endregion

        static string ProcConcate(string[] args)
        {
            string result = string.Empty; // == "";
            foreach (string s in args)
            {
                result += s + "/";
            }

            return result;
        }

        static void Main(string[] args)
        {
            #region < 대리자체인 영역 >
            //var loc = "우리집";
            //Call119(loc);
            //ShoutOut(loc);
            //Escape(loc);

            //// 불이 날수도 있으니까 미리 준비
            //var otherloc = "경찰서";
            //ThereIsAFire fire = new ThereIsAFire(Call119);
            //fire += new ThereIsAFire(ShoutOut);
            //fire += new ThereIsAFire(Escape); // 대리자에 메서드 추가

            //fire(otherloc);

            //fire -= new ThereIsAFire(ShoutOut); // 대리자에서 메서드를 삭제

            //fire("다른집");

            //// 익명함수
            //Calc plus = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Console.WriteLine(plus(6, 7));

            //Calc minus = (a, b) => { return a - b; };

            //Console.WriteLine(minus(67, 9));

            //Calc simpleMinus = (a, b) => a - b; // 람다식
            #endregion
            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Console.WriteLine("람다식으로");
            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty; // == "";
                foreach (string s in arr)
                {
                    res += s + "/";
                }

                return res;
            };
            Console.WriteLine(concat2(args));
        }
    }
}
