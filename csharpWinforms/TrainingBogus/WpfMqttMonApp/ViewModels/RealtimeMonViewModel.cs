using Caliburn.Micro;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using uPLibrary.Networking.M2Mqtt.Messages;
using WpfMqttMonApp.Helpers;

namespace WpfMqttMonApp.ViewModels
{
    public class RealtimeMonViewModel : Conductor<object>
    {
        double livingTempValue;
        public double LivingTempValue
        {
            get { return livingTempValue; }
            set
            {
                livingTempValue = value;
                NotifyOfPropertyChange(() => LivingTempValue);
            }
        }

        double livingHumidValue;
        public double LivingHumidValue
        {
            get { return livingHumidValue; }
            set
            {
                livingHumidValue = value;
                NotifyOfPropertyChange(() => LivingHumidValue);
            }
        }

        double livingPressValue;
        public double LivingPressValue
        {
            get { return livingPressValue; }
            set
            {
                livingPressValue = value;
                NotifyOfPropertyChange(() => LivingPressValue);
            }
        }

        double diningTempValue;
        public double DiningTempValue
        {
            get { return diningTempValue; }
            set
            {
                diningTempValue = value;
                NotifyOfPropertyChange(() => DiningTempValue);
            }
        }

        double diningHumidValue;
        public double DiningHumidValue
        {
            get { return diningHumidValue; }
            set
            {
                diningHumidValue = value;
                NotifyOfPropertyChange(() => DiningHumidValue);
            }
        }

        double diningPressValue;
        public double DiningPressValue
        {
            get { return diningPressValue; }
            set
            {
                diningPressValue = value;
                NotifyOfPropertyChange(() => DiningPressValue);
            }
        }

        double bedTempValue;
        public double BedTempValue
        {
            get { return bedTempValue; }
            set
            {
                bedTempValue = value;
                NotifyOfPropertyChange(() => BedTempValue);
            }
        }

        double bedHumidValue;
        public double BedHumidValue
        {
            get { return bedHumidValue; }
            set
            {
                bedHumidValue = value;
                NotifyOfPropertyChange(() => BedHumidValue);
            }
        }

        double bedPressValue;
        public double BedPressValue
        {
            get { return bedPressValue; }
            set
            {
                bedPressValue = value;
                NotifyOfPropertyChange(() => BedPressValue);
            }
        }

        public RealtimeMonViewModel()
        {
            LivingTempValue = LivingHumidValue = LivingPressValue = 0;
            DiningTempValue = DiningHumidValue = DiningPressValue = 0;
            BedTempValue = BedHumidValue = BedPressValue = 0;

            if (Commons.STATIC_CLIENT != null && Commons.STATIC_CLIENT.IsConnected)
                Commons.STATIC_CLIENT.MqttMsgPublishReceived += STATIC_CLIENT_MqttMsgPublishReceived;
        }

        private void STATIC_CLIENT_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            var currentDatas = JsonConvert.DeserializeObject<Dictionary<string, string>>(message);

            switch (currentDatas["Dev_Id"].ToString())
            {
                case "LivingRoom":
                    LivingTempValue = double.Parse(double.Parse(currentDatas["Temp"]).ToString("0.00"));
                    LivingHumidValue = double.Parse(double.Parse(currentDatas["Humid"]).ToString("0.00")); 
                    LivingPressValue = double.Parse(double.Parse(currentDatas["Press"]).ToString("0.00")); 
                    break;

                case "DiningRoom":
                    DiningTempValue = double.Parse(double.Parse(currentDatas["Temp"]).ToString("0.00"));
                    DiningHumidValue = double.Parse(double.Parse(currentDatas["Humid"]).ToString("0.00"));
                    DiningPressValue = double.Parse(double.Parse(currentDatas["Press"]).ToString("0.00"));
                    break;

                case "BedRoom":
                    BedTempValue = double.Parse(double.Parse(currentDatas["Temp"]).ToString("0.00"));
                    BedHumidValue = double.Parse(double.Parse(currentDatas["Humid"]).ToString("0.00"));
                    BedPressValue = double.Parse(double.Parse(currentDatas["Press"]).ToString("0.00"));
                    break;

                default:
                    break;
            }
        }
    }
}
