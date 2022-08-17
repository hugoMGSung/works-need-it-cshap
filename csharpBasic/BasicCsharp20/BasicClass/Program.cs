using System;
using System.Drawing;

namespace BasicClass
{
    class Cat
    {
        public string Name;
        public Color Color;

        public Cat()
        {
            Name = "";
            Color = Color.Transparent;
        }

        /// <summary>
        /// 파라미터 생성자
        /// </summary>
        /// <param name="name">고양이이름</param>
        /// <param name="color">고양이털색</param>
        public Cat(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}, 야옹~!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();  // 인스턴스화
            kitty.Name = "키티";
            kitty.Color = Color.White;
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", Color.Black);
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
