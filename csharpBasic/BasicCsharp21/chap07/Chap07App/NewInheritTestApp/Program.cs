using System;

namespace NewInheritTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("동물 클래스 상속");

            Animal animal = new Animal();
            animal.Name = "동물";
            animal.Age = 100;
            animal.Breath();

            Dog dog = new Dog();
            dog.Name = "마루";
            dog.Age = 2;
            dog.Breath();
            dog.HowOld();
            dog.Bark();
        }
    }
}
