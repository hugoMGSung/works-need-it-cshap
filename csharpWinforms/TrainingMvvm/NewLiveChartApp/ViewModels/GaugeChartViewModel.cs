using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewLiveChartApp.ViewModels
{
    public class GaugeChartViewModel : Conductor<object>
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyOfPropertyChange(() => Value);
            }
        }

        public Timer CustomTimer { get; set; }

        public GaugeChartViewModel()
        {
            CustomTimer = new Timer(TickCallBack);
            CustomTimer.Change(1000, 1000);

            Value = 160;
        }

        private void TickCallBack(object state)
        {
            Value = new Random().Next(50, 250);
        }

        public void UpdateValue()
        {
            Value = new Random().Next(50, 250);
        }
    }
}
