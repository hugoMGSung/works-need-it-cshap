using DecumanMRP.StaticInfo;
using System.Windows.Forms;

namespace DecumanMRP.Views
{
    public class LoadingScreen
    {
        static LoadingForm lf = null;

        public static void ShowSplashScreen()
        {
            if (lf == null)
            {
                lf = new LoadingForm
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                lf.ShowForm();
            }
        }

        public static void CloseSplashScreen()
        {
            if (lf != null)
            {
                lf.CloseForm();
                lf = null;
            }
        }
        public static void UdpateStatusText(string Text)
        {
            if (lf != null)
                lf.UdpateStatusText(Text);

        }

        public static void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {

            if (lf != null)
                lf.UdpateStatusTextWithStatus(Text, tom);
        }
    }
}
