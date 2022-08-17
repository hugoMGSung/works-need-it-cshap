using System;
using TensorFlow;

namespace HelloTensorFlowSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = new TFSession())
            {
                TFGraph graph = session.Graph;
                TFOutput a = graph.Const(2);
                TFOutput b = graph.Const(3);
                Console.WriteLine("a=2, b=3");
                // 상수 더하기
                TFTensor addProcess = session.GetRunner().Run(graph.Add(a, b));
                string Result = addProcess.GetValue().ToString();
                Console.WriteLine("a+b={0}", Result);
                // 상수 곱하기
                TFTensor multiProcess = session.GetRunner().Run(graph.Mul(a, b));
                Result = multiProcess.GetValue().ToString();

                Console.ReadLine();
            }
        }
    }
}
