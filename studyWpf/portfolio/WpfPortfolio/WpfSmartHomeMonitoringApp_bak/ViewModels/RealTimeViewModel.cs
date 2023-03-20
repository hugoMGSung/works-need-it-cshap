using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using WpfSmartHomeMonitoringApp.Helpers;

namespace WpfSmartHomeMonitoringApp.ViewModels
{
    public class RealTimeViewModel : Screen
    {
        private string livingTempVal;
        private string dinningTempVal;
        private string bedTempVal;
        private string bathTempVal;
        private double livingHumidVal;
        private double dinningHumidVal;
        private double bedHumidVal;
        private double bathHumidVal;

        public string LivingTempVal
        {
            get => livingTempVal; 
            set
            {
                livingTempVal = value;
                NotifyOfPropertyChange(() => LivingTempVal);
            }
        }
        public string DinningTempVal
        {
            get => dinningTempVal; 
            set
            {
                dinningTempVal = value;
                NotifyOfPropertyChange(() => DinningTempVal);
            }
        }
        public string BedTempVal
        {
            get => bedTempVal; 
            set
            {
                bedTempVal = value;
                NotifyOfPropertyChange(() => BedTempVal);
            }
        }
        public string BathTempVal
        {
            get => bathTempVal; 
            set
            {
                bathTempVal = value;
                NotifyOfPropertyChange(() => BathTempVal);
            }
        }

        public double LivingHumidVal
        {
            get => livingHumidVal; 
            set
            {
                livingHumidVal = value;
                NotifyOfPropertyChange(() => LivingHumidVal);
            }
        }
        public double DinningHumidVal
        {
            get => dinningHumidVal; 
            set
            {
                dinningHumidVal = value;
                NotifyOfPropertyChange(() => DinningHumidVal);
            }
        }
        public double BedHumidVal
        {
            get => bedHumidVal; 
            set
            {
                bedHumidVal = value;
                NotifyOfPropertyChange(() => BedHumidVal);
            }
        }
        public double BathHumidVal
        {
            get => bathHumidVal; 
            set
            {
                bathHumidVal = value;
                NotifyOfPropertyChange(() => BathHumidVal);
            }
        }

        public RealTimeViewModel()
        {
            Commons.BROKERHOST = "127.0.0.1";
            Commons.PUB_TOPIC = "home/device/#";

            LivingTempVal = DinningTempVal = BedTempVal = BathTempVal = String.Empty;
            LivingHumidVal = DinningHumidVal = BedHumidVal = BathHumidVal = 0;

            if (Commons.MQTT_CLIENT != null && Commons.MQTT_CLIENT.IsConnected)
                Commons.MQTT_CLIENT.MqttMsgPublishReceived += MQTT_CLIENT_MqttMsgPublishReceived;
            else // 접속이 안되어 있으면
            {
                Commons.MQTT_CLIENT = new MqttClient(Commons.BROKERHOST);
                Commons.MQTT_CLIENT.MqttMsgPublishReceived += MQTT_CLIENT_MqttMsgPublishReceived;
                Commons.MQTT_CLIENT.Connect("MONITOR");
                Commons.MQTT_CLIENT.Subscribe(new string[] { Commons.PUB_TOPIC },
                            new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                Commons.IS_CONNECT = true;
            }
        }

        private void MQTT_CLIENT_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            var currDatas = JsonConvert.DeserializeObject<Dictionary<string, string>>(message);

            switch (currDatas["DevId"].ToString())
            {
                case "LIVING":
                    LivingTempVal = double.Parse(currDatas["Temp"]).ToString("0.#");
                    LivingHumidVal = double.Parse(currDatas["Humid"]);
                    break;

                case "DINNING":
                    DinningTempVal = double.Parse(currDatas["Temp"]).ToString("0.#");
                    DinningHumidVal = double.Parse(currDatas["Humid"]);
                    break;

                case "BED":
                    BedTempVal = double.Parse(currDatas["Temp"]).ToString("0.#");
                    BedHumidVal = double.Parse(currDatas["Humid"]);
                    break;

                case "BATH":
                    BathTempVal = double.Parse(currDatas["Temp"]).ToString("0.#");
                    BathHumidVal = double.Parse(currDatas["Humid"]);
                    break;

                default:
                    break;
            }
        }
    }
}
