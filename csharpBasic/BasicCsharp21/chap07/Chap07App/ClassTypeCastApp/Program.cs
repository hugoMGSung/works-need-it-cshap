using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 a = new 포유류();
            a.키우다();

            a = new 강아지();
            a.키우다();

            (a as 강아지).멍멍();
            /*_포유류 = new 강아지();
            _포유류.키우다();*/
            //a = null;
            강아지 쭈쭈;

            if (a is 강아지)
            {
                쭈쭈 = a as 강아지;
                쭈쭈.멍멍();
            }

            //강아지 뽀삐 = null;
            강아지 뽀삐 = new 강아지();
            if (뽀삐 is 포유류)
            {
                Console.WriteLine("이부분이 실행됩니다.");
                포유류 mammel = new 포유류();
                뽀삐 = mammel as 강아지;
                if (뽀삐 != null) {
                    뽀삐.키우다();
                    뽀삐.멍멍();
                }
                
            }
        }
    }
}
