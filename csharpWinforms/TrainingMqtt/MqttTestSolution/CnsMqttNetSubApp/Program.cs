using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnsMqttNetSubApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagedMqttClientOptions options = new ManagedMqttClientOptions();

            options.ClientOptions = new MQTTnet.Client.MqttClientOptions()
            {
                ClientId = "MyClient",
                ChannelOptions = new MqttClientTcpOptions
                {
                    Server = "127.0.0.1",
                    Port = 1883,
                }
            };

            options.AutoReconnectDelay = TimeSpan.FromSeconds(1);

            try
            {
                var managedClient = new MqttFactory().CreateManagedMqttClient();
                managedClient.ApplicationMessageReceivedAsync += ManagedClient_ApplicationMessageReceivedAsync;

                managedClient.StartAsync(options);

                var topics = new List<MqttTopicFilter>();
                topics.Add(new MqttTopicFilter { Topic = "home/device/fakedata/", QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce });
                topics.Add(new MqttTopicFilter { Topic = "home/device/data/", QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce });
                managedClient.SubscribeAsync(topics);
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex);
            }
        }

        private static Task ManagedClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            Console.WriteLine($">>> Received : {arg.ApplicationMessage.Topic}");
            return Task.CompletedTask;
        }
    }
}
