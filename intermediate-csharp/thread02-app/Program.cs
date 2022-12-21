using System;

namespace thread02_app
{
    internal class IoT_Device
    {
        public void Run()
        {
            Console.WriteLine("IoT Device running~");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IoT_Device device = new IoT_Device();
            //Thread bw_device = new Thread(device.Run);
            //bw_device.Start();

            //Thread bw_temp_gathering = new Thread(new ThreadStart(GatherTemp));
            //bw_temp_gathering.Start();

            //Thread bw_pressure_gathering = new Thread(delegate () { GatherPressure(); });
            //bw_pressure_gathering.Start();

            //Thread bw_color_gathering = new Thread(() => GatherRGB()); // 가장 편한 방법
            //bw_color_gathering.Start();

            Thread bw_humid_gathering = new Thread(new ParameterizedThreadStart(GatherHumid));
            bw_humid_gathering.Start(98.9);

            // 가장 간단한 방법
            new Thread(() => ThreeSixNine(3, 6, 9)).Start();
        }

        private static void ThreeSixNine(int v1, int v2, int v3)
        {
            Console.WriteLine($"{v1} {v2} {v3}, {v1} {v2} {v3}!! 1, 2, 짝!");
        }

        private static void GatherHumid(object? humid)
        {
            Console.WriteLine($"습도 {humid} 이면 쪄 죽습니다~");
        }

        private static void GatherRGB()
        {
            Console.WriteLine("RGB 수집"); // 반복적으로 수행
        }

        private static void GatherPressure()
        {
            Console.WriteLine("압력값 수집"); // 반복적으로 수행
        }

        //private static void GatherHumid(/* object? obj */)
        //{
        //    Console.WriteLine("습도값 수집"); // 반복적으로 수행
        //} 

        private static void GatherTemp()
        {
            Console.WriteLine("온도값 수집"); // 반복적으로 수행
        }
    }
}