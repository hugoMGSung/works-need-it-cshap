using static System.Console;

namespace StringConcatenate2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";
            WriteLine(result);

            int result2 = 123 + 456;
            WriteLine(result2);

            result = "Hello" + " " + "World!";
            WriteLine(result);
        }
    }
}
