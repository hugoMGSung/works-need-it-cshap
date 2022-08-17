using Caliburn.Micro;
using LiveCharts;

namespace NewLiveChartApp.ViewModels
{
    public class LineChartViewModel : Conductor<object>
    {
        ChartValues<float> values;
        public ChartValues<float> Values {
            get => values;
            set {
                values = value;
                NotifyOfPropertyChange(() => Values);
            }
        }

        public LineChartViewModel()
        {
            Values = new ChartValues<float> { 3, 4, 6, 3, 2, 6 };
        }
    }
}
