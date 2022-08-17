using Caliburn.Micro;
using LiveCharts;
using LiveCharts.Defaults;
using NewLiveChartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewLiveChartApp.ViewModels
{
    internal class ContantChangeViewModel : Conductor<object>
    {
        private double _axisMax;
        private double _axisMin;
        private double _trend;

        ChartValues<MeasureModel> chartValues;
        public ChartValues<MeasureModel> ChartValues
        {
            get => chartValues;
            set
            {
                chartValues = value;
                NotifyOfPropertyChange(() => ChartValues);
            }

        }
        public Func<double, string> DateTimeFormatter { get; set; }
        public double AxisStep { get; set; }
        public double AxisUnit { get; set; }

        public double AxisMax
        {
            get { return _axisMax; }
            set
            {
                _axisMax = value;
                NotifyOfPropertyChange(() => AxisMax);
            }
        }
        public double AxisMin
        {
            get { return _axisMin; }
            set
            {
                _axisMin = value;
                NotifyOfPropertyChange(() => AxisMin);
            }
        }

        public ChartValues<ObservableValue> Values1 { get; set; }
        public ChartValues<ObservableValue> Values2 { get; set; }

        public ContantChangeViewModel()
        {
            Task.Factory.StartNew(Read);

            Values1 = new ChartValues<ObservableValue>
            {
                new ObservableValue(3),
                new ObservableValue(4),
                new ObservableValue(6),
                new ObservableValue(3),
                new ObservableValue(2),
                new ObservableValue(6)
            };
            Values2 = new ChartValues<ObservableValue>
            {
                new ObservableValue(5),
                new ObservableValue(3),
                new ObservableValue(5),
                new ObservableValue(7),
                new ObservableValue(3),
                new ObservableValue(9)
            };
        }

        private void Read()
        {
            var r = new Random();

            while (true)
            {
                Thread.Sleep(150);
                var now = DateTime.Now;

                _trend += r.Next(-8, 10);

                ChartValues.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = _trend
                });

                SetAxisLimits(now);

                //lets only use the last 150 values
                if (ChartValues.Count > 150) ChartValues.RemoveAt(0);
            }
        }

        private void SetAxisLimits(DateTime now)
        {
            AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            AxisMin = now.Ticks - TimeSpan.FromSeconds(8).Ticks; // and 8 seconds behind
        }
    }
}
