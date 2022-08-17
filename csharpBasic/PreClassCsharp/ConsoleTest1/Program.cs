using static System.Console;

namespace ConsoleTest1
{
    class Program
    {
        enum myType
        {
            Yes,
            No,
            Confirm,
            Cancel,
            OK
        };

        static void Main(string[] args)
        {
            int a = 10;
            a += 1;
            
            WriteLine(a);            
            object c = a.GetType();
            WriteLine(c);
        }
    }
}
