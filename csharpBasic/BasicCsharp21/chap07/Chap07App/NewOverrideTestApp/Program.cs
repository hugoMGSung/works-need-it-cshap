using System;

namespace NewOverrideTestApp
{
    class Mammal { // 포유류
        public string Name { get; set; }

        public void Breathe() {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }

        public virtual void Move() {           
            Console.WriteLine($"(부모작업) {this.Name}이(가) 이동한다.");
        }
    }

    class Dog : Mammal {        
        public override void Move()
        {
            base.Move(); // 부모에 있는 Move 실행
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다."); // +alpha 실행
        }
    }

    class Human : Mammal {
        public new void Move() { // 부모의 메서드 숨긴다.
            Console.WriteLine($"{this.Name}이(가) 두발로 움직인다.");
        }
    }

    class Whale : Mammal { // 고래
        public void Move() { // 부모의 메서드를 재정의
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog ppoppi = new Dog();
            ppoppi.Name = "Ppoppi";
            ppoppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식이";
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();

            Mammal mammal = new Dog();
            mammal.Name = "포유류";
            mammal.Move();


        }
    }
}
