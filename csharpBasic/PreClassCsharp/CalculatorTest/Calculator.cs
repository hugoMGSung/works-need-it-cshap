using static System.Console;

namespace CalculatorTest {
    public class Calculator {
        public int Plus(int a, int b) {
            WriteLine($"input are {a} and {b}");
            int result = a + b;
            return result;
        }

        public float Plus(float a, float b)
        {
            WriteLine($"input are {a} and {b}");
            float result = a + b;
            return result;
        }

        public static int Minus(int a, int b) {
            WriteLine($"input are {a} and {b}");
            int result = a - b;
            return result;
        }

        public static int Multiple(int a, int b) {
            WriteLine($"input are {a} and {b}");
            int result = a * b;
            return result;
        }

        public static int Divide(int a, int b) {
            WriteLine($"input are {a} and {b}");
            int result = a / b;
            return result;
        }
    }
}
