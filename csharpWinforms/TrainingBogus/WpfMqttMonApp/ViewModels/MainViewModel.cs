using Caliburn.Micro;
using System;
using WpfMqttMonApp.Helpers;

namespace WpfMqttMonApp.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        public MainViewModel()
        {
            DisplayName = "MQTT Monitoring App";
        }

        protected override void OnDeactivate(bool close)
        {
            if (Commons.STATIC_CLIENT.IsConnected)
            {
                Commons.STATIC_CLIENT.Disconnect();
                Commons.STATIC_CLIENT = null;
            }

            base.OnDeactivate(close);
        }

        public async void PopInfoDialog(object o)
        {
            TaskStart();
        }

        public void StartSubscriber()
        {
            TaskStart();
        }

        private void TaskStart()
        {
            var windowManager = new WindowManager();
            var result = windowManager.ShowDialog(new CustomPopupViewModel("New Network"));

            if (result == true)
            {
                //MessageBox.Show("True");
                ActivateItem(new DatabaseMonViewModel());
            }
        }

        public void LoadDatabaseView()
        {
            if (Commons.STATIC_CLIENT != null)
            {
                ActivateItem(new DatabaseMonViewModel());
            }
            else
            {
                var windowManager = new WindowManager();
                windowManager.ShowDialog(new ErrorPopupViewModel("Report|MQTT doesn't start, yet"));
            }
        }

        public void LoadRealTimeView()
        {
            ActivateItem(new RealtimeMonViewModel());
        }

        public void LoadHistoryView()
        {
            ActivateItem(new HistoryViewModel());
        }

        public void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}
