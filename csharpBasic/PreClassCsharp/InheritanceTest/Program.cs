using System;

namespace InheritanceTest
{
    public class Base {
        protected int BaseVal = 10;
        public void BaseMethod() {
            Console.WriteLine("BaseMethod");
        }
    }
    public class Derived : Base {
        public double DerivedVal = 10.56;      
        
        public void DerivedMethod() {
            DerivedVal = (double) base.BaseVal + 11;
            base.BaseMethod();
            Console.Write("TEST");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
