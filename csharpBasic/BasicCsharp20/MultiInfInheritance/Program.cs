using System;

namespace MultiInfInheritance
{
    class Program
    {
        interface IRunnable
        {
            void Run();
        }

        interface IFlyable
        {
            void Fly();
        }

        interface IWalkable
        {
            void Run(int value);
        }

        public class Vehicle
        {
            public string Year;
            public string Company;
            public float HorsePower;
        }

        class FlyingCar : Vehicle, IRunnable, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Fly!");
            }

            public void Run()
            {
                Console.WriteLine("Run!");
            }
        }

        class TestClass : IRunnable, IWalkable
        {
            public void Run()
            {
                Console.WriteLine("Duplicated Interface");
            }

            public void Run(int value)
            {
                Console.WriteLine($"Run as {value}");
            }
        }

        static void Main(string[] args)
        {
            //FlyingCar car = new FlyingCar();
            //car.Run();
            //car.Fly();
            //car.Company = "현대";

            //IRunnable runnable = car as IRunnable;
            //runnable.Run();

            //IFlyable flyable = car as IFlyable;
            //flyable.Fly();

            TestClass test = new TestClass();
            test.Run();

            IWalkable w = test as IWalkable;
            w.Run(30);
            IRunnable t = test as IRunnable;
            t.Run();
        }
    }
}
