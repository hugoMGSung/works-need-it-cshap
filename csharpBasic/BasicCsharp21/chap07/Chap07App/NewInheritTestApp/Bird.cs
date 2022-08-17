using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine($"{this.Name}이 납니다!!");
        }
    }
}
