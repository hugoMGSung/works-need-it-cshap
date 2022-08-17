using MQTTnet;
using MQTTnet.Client;
using System.Threading;
using System.Threading.Tasks;

namespace CnsMqttNetPubApp
{
    internal class Program
    {
        private static async Task Main()
        {
            await ClientTest();
        }

        private static async Task ClientTest()
        {
            var mqttClient = new MqttFactory().CreateMqttClient();

            //var options = new MqttClientOptionsBuilder().WithTcpServer("127.0.0.1", 1883).WithCredentials("username", "password").Build();
            var options = new MqttClientOptionsBuilder().WithTcpServer("127.0.0.1", 1883).Build();

            var message = new MqttApplicationMessageBuilder().WithTopic("home/device/netdata/").WithPayload("TestMessage").Build();

            var result = await mqttClient.ConnectAsync(options, CancellationToken.None);

            if (result.ResultCode == MqttClientConnectResultCode.Success)
            {
                await mqttClient.PublishAsync(message);
            }
        }
    }
}
