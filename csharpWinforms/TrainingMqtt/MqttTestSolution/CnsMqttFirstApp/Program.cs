using Bogus;
using HugoLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace CnsMqttFirstApp
{
    internal class Program
    {
        public static MqttClient MyClient { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("M2Mqtt Test");

            MyClient = new MqttClient("127.0.0.1");
            string clientId = Guid.NewGuid().ToString();
            MyClient.Connect(clientId);

            StartPublish();
            StartPublish2();
        }

        private static void StartPublish2()
        {
            Thread MqttThread = new Thread(() => LoopPublish2());
            MqttThread.Start();
        }

        private static void LoopPublish2()
        {
            while (true)
            {
                Faker<SensorInfo> faker = HStatics.GetSensorFakeRule();
                SensorInfo tempVal = faker.Generate();
                string currValue = HStatics.GetJsonData(tempVal);
                MyClient.Publish("home/device/newdata/", Encoding.Default.GetBytes(currValue));
                Console.WriteLine($"Published2 : {currValue}");
                Thread.Sleep(1000);
            }
        }

        private static void StartPublish()
        {
            Thread MqttThread = new Thread(() => LoopPublish());
            MqttThread.Start();
        }

        private static void LoopPublish()
        {
            while (true)
            {
                Faker<SensorInfo> faker = HStatics.GetSensorFakeRule();
                SensorInfo tempVal = faker.Generate();
                string currValue = HStatics.GetJsonData(tempVal);
                MyClient.Publish("home/device/fakedata/", Encoding.Default.GetBytes(currValue));
                Console.WriteLine($"Published : {currValue}");
                Thread.Sleep(1000);
            }
        }
    }
}
