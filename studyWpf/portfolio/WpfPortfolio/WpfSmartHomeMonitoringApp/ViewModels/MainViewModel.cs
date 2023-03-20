using Caliburn.Micro;
using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WpfSmartHomeMonitoringApp.Helpers;

namespace WpfSmartHomeMonitoringApp.ViewModels
{
    public class AccentColorMenuData
    {
        public string Name { get; set; }

        public Brush BorderColorBrush { get; set; }

        public Brush ColorBrush { get; set; }

        public AccentColorMenuData()
        {
            this.ChangeAccentCommand = new SimpleCommand(o => true, this.DoChangeTheme);
        }

        public ICommand ChangeAccentCommand { get; }

        protected virtual void DoChangeTheme(object sender)
        {
            ThemeManager.Current.ChangeThemeColorScheme(Application.Current, this.Name);
        }
    }

    public class AppThemeMenuData : AccentColorMenuData
    {
        protected override void DoChangeTheme(object sender)
        {
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, this.Name);
        }
    }

    public class MainViewModel : Conductor<object>  // Screen에는 ActivateItem[Async] 메서드 없음
    {
        public List<AppThemeMenuData> AppThemes { get; set; }

        public List<AccentColorMenuData> AccentColors { get; set; }

        public MainViewModel()
        {
            DisplayName = "SmartHome Monitoring v2.0"; // 윈도우 타이틀, 제목

            // create accent color menu items for the demo
            this.AccentColors = ThemeManager.Current.Themes
                                            .GroupBy(x => x.ColorScheme)
                                            .OrderBy(a => a.Key)
                                            .Select(a => new AccentColorMenuData { Name = a.Key, ColorBrush = a.First().ShowcaseBrush })
                                            .ToList();

            // create metro theme color menu items for the demo
            this.AppThemes = ThemeManager.Current.Themes
                                         .GroupBy(x => x.BaseColorScheme)
                                         .Select(x => x.First())
                                         .Select(a => new AppThemeMenuData() { Name = a.BaseColorScheme, BorderColorBrush = a.Resources["MahApps.Brushes.ThemeForeground"] as Brush, ColorBrush = a.Resources["MahApps.Brushes.ThemeBackground"] as Brush })
                                         .ToList();
        }

        protected override Task OnDeactivateAsync(bool close, CancellationToken cancellationToken)
        {
            if (Commons.MQTT_CLIENT.IsConnected)
            {
                Commons.MQTT_CLIENT.Disconnect();
                Commons.MQTT_CLIENT = null;
            } // 비활성화 처리

            return base.OnDeactivateAsync(close, cancellationToken);
        }

        public void LoadRealTimeView()
        {
            ActivateItemAsync(new RealTimeViewModel());
        }

        public void LoadDataBaseView()
        {
            ActivateItemAsync(new DataBaseViewModel());
        }

        public void LoadHistoryView()
        {
            ActivateItemAsync(new HistoryViewModel());
        }

        public void ExitProgram()
        {
            Environment.Exit(0); // 프로그램 종료
        }

        public void ExitToolbar()
        {
            Environment.Exit(0); // 프로그램 종료
        }

        // Start 메뉴, 아이콘 눌렀을때 처리할 이벤트
        public void PopInfoDialog()
        {
            TaskPopup();
        }

        public void StartSubscribe()
        {
            TaskPopup();
        }

        private void TaskPopup()
        {
            // CustomPopupView
            var winManager = new WindowManager();
            var result = winManager.ShowDialogAsync(new CustomPopupViewModel("New Broker"));

            if (result.Result == true)
            {
                ActivateItemAsync(new DataBaseViewModel());
            }
        }

        public void PopInfoView()
        {
            var winManager = new WindowManager();
            winManager.ShowDialogAsync(new CustomInfoViewModel("About"));
        }
    }
}
