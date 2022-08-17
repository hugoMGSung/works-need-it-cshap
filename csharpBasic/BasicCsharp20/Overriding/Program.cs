using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();

            ArmorSuite warMachine = new WarMachine();
            warMachine.Initialize();
        }
    }
}
