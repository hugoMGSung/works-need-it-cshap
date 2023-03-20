using Caliburn.Micro;
using System.Reflection;

namespace WpfSmartHomeMonitoringApp.ViewModels
{
    public class CustomInfoViewModel : Conductor<object>
    {
        private string applicationInfo;

        public string ApplicationInfo
        {
            get => applicationInfo; set
            {
                applicationInfo = value;
                NotifyOfPropertyChange(() => ApplicationInfo);
            }
        }

        public CustomInfoViewModel(string title)
        {
            this.DisplayName = title;
            setApplicationInfo();
        }

        private void setApplicationInfo()
        {
            ApplicationInfo = AssemblyTitle + " Ver." + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ApplicationInfo += "\n" + AssemblyCopyright;
        }

        public void AcceptClose()
        {
            // 창닫기
            TryCloseAsync(true);
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
    }
}
