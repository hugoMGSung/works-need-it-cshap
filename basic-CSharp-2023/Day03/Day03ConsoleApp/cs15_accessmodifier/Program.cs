using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_accessmodifier
{
    internal class WaterHeater // class에 기본 접근한정자 internal
    {
        protected int temp;

        public void SetTemp(int temp)
        {
            if (temp < -5 || temp > 40)
            {
                Console.WriteLine("범위 이탈");
                return;
            }

            this.temp = temp;
        }

        public int GetTemp()
        {
            return this.temp;
        }

        internal void TurnOnHeater()
        {
            Console.WriteLine("보일러 켭니다 : {0}", temp);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater boiler = new WaterHeater();
            boiler.SetTemp(30);
            Console.WriteLine(boiler.GetTemp());
            boiler.TurnOnHeater();
            // boiler.temp = 38;
        }
    }
}
