using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_override
{
    class ArmorSuite // 
    {
        public virtual void Init()  // public virtual ...
        {
            Console.WriteLine("기본 아머슈트");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Init()
        {
            base.Init();
            Console.WriteLine("리펄서 빔!");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Init()
        {
            // base.Init(); // 부모클래스의 Init() 실행안함
            Console.WriteLine("미니건");
            Console.WriteLine("돌격소총");
        }
    }

    class Parent
    {
        public void CurrentMethod()
        {
            Console.WriteLine("부모클래스 메서드");
        }
    }

    class Child : Parent
    {
        public new void CurrentMethod()
        {
            Console.WriteLine("자식클래스 메서드");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아머슈트 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Init();

            Console.WriteLine("워머신 생산");
            WarMachine machine = new WarMachine();
            machine.Init();

            Console.WriteLine("아이언맨 생산");
            IronMan iron = new IronMan();
            iron.Init();

            Parent parent = new Parent();
            parent.CurrentMethod();

            Child child = new Child();
            child.CurrentMethod();
        }
    }
}
