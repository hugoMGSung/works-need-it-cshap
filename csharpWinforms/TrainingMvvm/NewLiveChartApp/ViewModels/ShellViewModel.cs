using Caliburn.Micro;
using LiveCharts;
using System;

namespace NewLiveChartApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {

        }

        public void LoadLineChart()
        {
            ActivateItem(new LineChartViewModel());
        }

        public void LoadGaugeChart()
        {
            ActivateItem(new GaugeChartViewModel());
        }

        public void LoadGauge360Chart()
        {
            ActivateItem(new GaugeCircleViewModel());
        }

        public void LoadBasicBarChart()
        {
            ActivateItem(new BasicBarViewModel());
        }

        public void LoadBasicLineAndBubble()
        {
            ActivateItem(new BasicLineAndBubbleViewModel());
        }

        public void LoadConstantChart()
        {
            ActivateItem(new ContantChangeViewModel());
        }

        public void LoadCandleChart()
        {
            ActivateItem(new CandleChartViewModel());
        }

        public void LoadPieChart()
        {
            ActivateItem(new PieChartViewModel());
        }

        public void LoadSpeedTest()
        {
            ActivateItem(new SpeedTestViewModel());
        }

        public void LoadMaterialDesign()
        {
            ActivateItem(new MaterialViewModel());
        }

        public void LoadRealtimeChart()
        {
            ActivateItem(new RealTimeChartViewModel());
        }
    }
}
