using Bogus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace DummyDataApp
{
    internal class Program
    {
        public static string MqttBrokerUrl { get; set; }
        public static MqttClient Client { get; set; }
        private static Thread MqttThread { get; set; }
        private static Faker<SensorInfo> SensorData { get; set; }
        private static string CurrValue { get; set; }

        static void Main(string[] args)
        {
            InitializeConfig();  // 구성초기화
            ConnectMqttBroker();  // 브로커에 접속
            StartPublish();  // 배포(Publish 발행)
        }

        private static void InitializeConfig()
        {
            MqttBrokerUrl = "127.0.0.1"; // "localhost"; //"127.0.0.1";

            var Rooms = new[] { "DINNING", "LIVING", "BATH", "BED" }; // 부엌, 거실, 욕실, 침실

            SensorData = new Faker<SensorInfo>()
                .RuleFor(r => r.DevId, f => f.PickRandom(Rooms))
                .RuleFor(r => r.CurrTime, f => f.Date.Past(0))
                .RuleFor(r => r.Temp, f => f.Random.Float(19.0f, 30.9f))
                .RuleFor(r => r.Humid, f => f.Random.Float(40.0f, 63.9f));
        }

        private static void ConnectMqttBroker()
        {
            try
            {
                Client = new MqttClient(MqttBrokerUrl);
                Client.Connect("SMARTHOME01");
                Console.WriteLine("접속성공!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"접속불가 : {ex}");
                Environment.Exit(5); // ERROR_ACCESS_DENIED 
            }           
        }

        private static void StartPublish()
        {
            MqttThread = new Thread(() => LoopPublish());
            MqttThread.Start();

            //Thread thread2 = new Thread(() => LoopPublish2());
            //thread2.Start();

            //Thread thread3 = new Thread(() => LoopPublish3());
            //thread3.Start();
        }

        private static void LoopPublish3()
        {
            while (true)
            {
                SensorInfo tempValue = SensorData.Generate();
                tempValue.DevId = "TEST";
                CurrValue = JsonConvert.SerializeObject(tempValue, Formatting.Indented);
                Client.Publish("home/device/testdata/", Encoding.Default.GetBytes(CurrValue));
                Console.WriteLine($"Published testdata : {CurrValue}");
                Thread.Sleep(2000);
            }
        }

        // LoopPublish하고 별개 동작하는 태스크
        private static void LoopPublish2()
        {
            while (true)
            {
                SensorInfo tempValue = SensorData.Generate();
                tempValue.DevId = Guid.NewGuid().ToString(); // newdata topic DEVID 변경.
                CurrValue = JsonConvert.SerializeObject(tempValue, Formatting.Indented);
                Client.Publish("home/device/newdata/", Encoding.Default.GetBytes(CurrValue));
                Console.WriteLine($"Published newdata : {CurrValue}");
                Thread.Sleep(1500);
            }
        }

        // Main 메서드 실행되는 부분하는 별개로 동작하는 태스크
        private static void LoopPublish()
        {
            while (true)
            {
                SensorInfo tempValue = SensorData.Generate();
                CurrValue = JsonConvert.SerializeObject(tempValue, Formatting.Indented);
                Client.Publish("home/device/fakedata/", Encoding.Default.GetBytes(CurrValue));
                Console.WriteLine($"Published fakedata : {CurrValue}");
                Thread.Sleep(1000);
            }
        }
    }
}
