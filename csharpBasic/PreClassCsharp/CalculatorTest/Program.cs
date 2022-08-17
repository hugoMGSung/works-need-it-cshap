using static System.Console;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 5;

            float a = 100.0f;
            float b = 5.1f;

            Calculator cal = new Calculator();

            int result = cal.Plus(x, y);
            WriteLine($"{x}     + {y} 계산 결과 {result}");

            

            
        }
    }
}
