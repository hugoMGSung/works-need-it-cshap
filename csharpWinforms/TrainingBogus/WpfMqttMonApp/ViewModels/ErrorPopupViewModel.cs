using Caliburn.Micro;

namespace WpfMqttMonApp.ViewModels
{
    internal class ErrorPopupViewModel : Conductor<object>
    {
        string reportMessage;
        public string ReportMessage {
            get => reportMessage;
            set
            {
                reportMessage = value;
                NotifyOfPropertyChange(() => ReportMessage);
            } 
        }

        public ErrorPopupViewModel(string v)
        {
            var tmp = v.Split('|');
            this.DisplayName = tmp[0];
            ReportMessage = tmp[1];
        }

        public void CloseAccept()
        {
            TryClose(true);
        }
    }
}