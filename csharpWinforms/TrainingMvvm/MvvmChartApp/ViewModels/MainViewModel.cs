using Caliburn.Micro;
using System;

namespace MvvmChartApp.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        public MainViewModel()
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

        public void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}
