using Caliburn.Micro;
using System;
using System.Threading;

namespace NewLiveChartApp.ViewModels
{
    public class GaugeCircleViewModel :Conductor<object>
    {
        double value1;
        public double Value1
        {
            get { return value1; }
            set
            {
                value1 = value;
                NotifyOfPropertyChange(() => Value1);
            }
        }

        double value2;
        public double Value2
        {
            get { return value2; }
            set
            {
                value2 = value;
                NotifyOfPropertyChange(() => Value2);
            }
        }

        double value3;
        public double Value3
        {
            get { return value3; }
            set
            {
                value3 = value;
                NotifyOfPropertyChange(() => Value3);
            }
        }

        double value4;
        public double Value4
        {
            get { return value4; }
            set
            {
                value4 = value;
                NotifyOfPropertyChange(() => Value4);
            }
        }

        double value5;
        public double Value5
        {
            get { return value5; }
            set
            {
                value5 = value;
                NotifyOfPropertyChange(() => Value5);
            }
        }

        double value6;
        public double Value6
        {
            get { return value6; }
            set
            {
                value6 = value;
                NotifyOfPropertyChange(() => Value6);
            }
        }
        public Timer GaugeTimer { get; set; }

        public GaugeCircleViewModel()
        {
            Value1 = Value2 = Value3 = Value4 = Value5 = Value6 = 0;

            GaugeTimer = new Timer(TickCallBack);
            GaugeTimer.Change(1000, 1000);
        }

        private void TickCallBack(object state)
        {
            var temp = new Random();
            Value1 = temp.Next(10, 99);
            Value2 = temp.Next(0, 100);
            Value3 = temp.Next(10, 90);
            Value4 = temp.Next(5, 100);
            Value5 = temp.Next(11, 98);
            Value6 = temp.Next(22, 30);
        }
    }
}
