using Caliburn.Micro;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace NewLiveChartApp.ViewModels
{
    internal class MaterialViewModel : Conductor<object>
    {
        private double _lastLecture;
        private double _trend;

        public MaterialViewModel()
        {
            LastHourSeries = new SeriesCollection
            {
                new LineSeries
                {
                    AreaLimit = -10,
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(23),
                        new ObservableValue(51),
                        new ObservableValue(6),
                        new ObservableValue(7),
                        new ObservableValue(3),
                        new ObservableValue(4),
                        new ObservableValue(2),
                        new ObservableValue(5),
                        new ObservableValue(8),
                        new ObservableValue(3),
                        new ObservableValue(5),
                        new ObservableValue(6),
                        new ObservableValue(7),
                        new ObservableValue(3),
                        new ObservableValue(4),
                        new ObservableValue(2),
                        new ObservableValue(5),
                        new ObservableValue(82)
                    }
                }
            };
            _trend = 8;


            //Task.Factory.StartNew(() =>
            //{
            //    var r = new Random();

            //    Action action = delegate
            //    {
            //        LastHourSeries[0].Values.Add(new ObservableValue(_trend));
            //        LastHourSeries[0].Values.RemoveAt(0);
            //        SetLecture();
            //    };

            //    while (true)
            //    {
            //        Thread.Sleep(500);
            //        _trend += (r.NextDouble() > 0.3 ? 1 : -1) * r.Next(0, 5);
            //        Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, action);
            //    }
            //});

            //Task.Run(() =>
            //{
            //    var r = new Random();
            //    while (true)
            //    {
            //        Thread.Sleep(500);
            //        _trend += (r.NextDouble() > 0.3 ? 1 : -1) * r.Next(0, 5);
            //        Application.Current.Dispatcher.Invoke(() =>
            //        {
            //            LastHourSeries[0].Values.Add(new ObservableValue(_trend));
            //            LastHourSeries[0].Values.RemoveAt(0);
            //            SetLecture();
            //        });
            //    }
            //});
        }

        public SeriesCollection LastHourSeries { get; set; }

        public double LastLecture
        {
            get { return _lastLecture; }
            set
            {
                _lastLecture = value;
                NotifyOfPropertyChange(() => LastLecture);
            }
        }
    }
}
