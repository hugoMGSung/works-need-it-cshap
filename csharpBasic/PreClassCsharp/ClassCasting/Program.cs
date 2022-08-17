using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCasting { 
    class Mammal {
        public void Nurse() {
            Console.WriteLine("Nurse");
        }
    }
    class Cat : Mammal {
        public void Meow() {
            Console.WriteLine("야옹");
        }
    }
    class Dog : Mammal {
        public void Bark() {
            Console.WriteLine("멍멍");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog) {
                dog = mammal as Dog;
                dog.Bark();
            }
        }
    }
}
