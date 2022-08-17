using System;

namespace NewInheritTestApp
{
    class Animal // 동물 클래스
    {
        public string Name { get; set; } // 프로퍼티
        public int Age { get;  set; }

        public void Breath()
        {
            Console.WriteLine($"{this.Name} 이 숨을 쉽니다.");
        }
    }
}
