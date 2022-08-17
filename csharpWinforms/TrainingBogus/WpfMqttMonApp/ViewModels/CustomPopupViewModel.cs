using Caliburn.Micro;
using WpfMqttMonApp.Helpers;

namespace WpfMqttMonApp.ViewModels
{
    internal class CustomPopupViewModel : Conductor<object>
    {
        string host;
        public string Host
        {
            get => host;
            set
            {
                host = value;
                NotifyOfPropertyChange(() => Host);
            }
        }

        string subscriber;
        public string Subscriber {
            get => subscriber;
            set
            {
                subscriber = value;
                NotifyOfPropertyChange(() => Subscriber);
            } 
        }

        public CustomPopupViewModel(string v)
        {
            this.DisplayName = v;

            Host = "localhost";
            Subscriber = "home/device/data/";
        }

        public void CloseAccept()
        {
            Commons.BROKERHOST = Host;
            Commons.PUB_TOPIC = Subscriber;

            TryClose(true);
        }
    }
}