using System;
using System.IO;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now; 
            Console.WriteLine($"[{now.ToLocalTime()}] {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            writer.WriteLine($"[{now.ToLocalTime()}] {message}");
        }
    }

    class ClimateMonitor {
        private ILogger logger;

        public ClimateMonitor(ILogger logger) {
            this.logger = logger;
        }

        public void start() { 
            while (true) {
                Console.Write("온도 입력 : ");
                string temp = Console.ReadLine();
                if (temp == "q")
                    break;

                logger.WriteLog("현재온도 : " + temp);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(
            //    new FileLogger("climate.log")
            //    );
            ClimateMonitor monitor = new ClimateMonitor(
                new ConsoleLogger()
                );
            monitor.start();
        }
    }
}
