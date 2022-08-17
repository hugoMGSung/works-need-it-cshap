using Bogus;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;

namespace BogusMqttApp
{
    class Program
    {
        public static string MqttBrokerUrl { get; private set; }
        public static MqttClient Client { get; private set; }
        private static Thread MqttThread { get; set; }
        private static Faker<SensorInfo> SensorFaker { get; set; }
        private static string CurrValue { get; set; }

        static void Main(string[] args)
        {
            InitializeAll();        // 전체 초기화
            ConnectMqttBroker();    // MQTT 브로커 접속
            StartPublish();         // fake 센싱 메시지 전송
        }

        private static void StartPublish()
        {
            MqttThread = new Thread(() => LoopPublish());
            MqttThread.Start();
        }

        private static void LoopPublish()
        {
            while (true)
            {
                SensorInfo ThisValue = SensorFaker.Generate();
                CurrValue = JsonConvert.SerializeObject(ThisValue, Formatting.Indented);
                Client.Publish("home/device/data/", Encoding.Default.GetBytes(CurrValue));
                Console.WriteLine($"Published : {CurrValue}");
                Thread.Sleep(1000);
            }
        }

        private static void InitializeAll()
        {
            MqttBrokerUrl = "localhost";

            var Rooms = new[] { "DiningRoom", "LivingRoom", "BathRoom", "BedRoom" };

            SensorFaker = new Faker<SensorInfo>()
                .RuleFor(o => o.Dev_Id, f => f.PickRandom(Rooms))
                .RuleFor(o => o.Curr_Time, f => f.Date.Past(0))
                .RuleFor(o => o.Temp, f => f.Random.Float(20.0f, 35.9f))
                .RuleFor(o => o.Humid, f => f.Random.Float(40.0f, 63.9f))
                .RuleFor(o => o.Press, f => f.Random.Float(899.0f, 1005.9f));
        }

        private static void ConnectMqttBroker()
        {
            Client = new MqttClient(MqttBrokerUrl);
            Client.Connect("FakerDaemon");
        }
    }
}
