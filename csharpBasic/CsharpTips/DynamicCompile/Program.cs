using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Diagnostics;

namespace DynamicCompile
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 컴파일러 객체 생성
            CodeDomProvider codeDom = CodeDomProvider.CreateProvider("CSharp");

            // 컴파일러 파라미터 옵션 지정
            CompilerParameters csparams = new CompilerParameters();
            csparams.GenerateInMemory = true;
            csparams.ReferencedAssemblies.Add("System.dll");

            // 소스코드를 컴파일해서 EXE 생성
            CompilerResults results = codeDom.CompileAssemblyFromSource(cparams, code);

            // 컴파일 에러 있는 경우 표시
            if (results.Errors.Count > 0)
            {
                foreach (var err in results.Errors)
                {
                    Console.WriteLine(err.ToString());
                }
                return;
            }

            // (Optional) 테스트 실행
            Process.Start("TEST.EXE");
        }

        static string[] GetCode()
        {
            return new string[]
            {
                @"using System;
 
                namespace DynamicNS
                {
                    public static class DynamicCode
                    {
                        public static void DynamicMethod()
                        {
                            Console.WriteLine(""Hello, world!"");
                        }
                    }
                }"
            };
        }
    }
}
