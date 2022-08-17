using System;

namespace BasicClass { 
    public class Cat {
        private string name;
        private string color;
        public Cat(string _name, string _color) {
            name = _name;
            color = _color;
        }
        public void Meow(int count) {
            for (int i = 0; i < count; i++) {
                Console.WriteLine("야옹!!");
            }            
        }
        public void Print() {
            Console.WriteLine($"고양이 이름은 {this.name} 이고 색상은 {this.color}.");
        }
    }

    public class Program {
        public static void Main(string[] args)
        {
            Cat 하양이 = new Cat("하양이", "하얀색");
            하양이.Meow(3);
            하양이.Print();
        }
    }
}
