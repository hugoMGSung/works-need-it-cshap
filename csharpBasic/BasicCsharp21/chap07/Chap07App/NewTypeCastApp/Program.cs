using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal // 포유류
    {
        public string Name { get; set; }

        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을(를) 키우다");
        }
    }

    class Dog : Mammal // 강아지
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal // 야옹이
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog ppoppi = null; // new Dog();
            /*ppoppi.Name = "뽀삐";
            ppoppi.Nurse();
            ppoppi.Bark();*/

            /*Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();*/

            if (ppoppi is Mammal) // 뽀삐는 포유류인가????
            {
                // 값형식은 long = int값;
                Mammal mammal1 = ppoppi; // 참조형식은 as를 써서 형변환
                mammal1.Nurse();
                // mammal1.Bark();  // error
            }

            if (mammal is Dog)
            {
                ppoppi = mammal as Dog;
                ppoppi.Nurse();
                ppoppi.Bark();
            }
        }
    }
}
