using static System.Console;

/// <summary>
/// HelloApp 네임스페이스
/// </summary>
namespace HelloApp
{
    /// <summary>
    /// 기본 클래스
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// 엔트리포인트 메서드
        /// </summary>
        /// <param name="args">입력 매개변수</param>        
        static void Main(string[] args)
        {            
            if (args.Length == 0)
            {
                WriteLine("ex: HelloApp.exe <이름>");
                return;
            }

            WriteLine($"Hello, {args[0]}!");
        }
    }
}
