using uPLibrary.Networking.M2Mqtt;

namespace WpfSmartHomeMonitoringApp.Helpers
{
    public class Commons
    {
        public static string BROKERHOST { get; set; }
        public static string PUB_TOPIC { get; set; }
        public static MqttClient MQTT_CLIENT { get; set; }
        public static string CONNSTRING { get; set; }
        public static bool IS_CONNECT { get; set; }
    }
}
