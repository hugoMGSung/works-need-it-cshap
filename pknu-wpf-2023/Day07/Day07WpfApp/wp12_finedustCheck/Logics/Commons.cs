using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using System.Threading.Tasks;
using System.Windows;

namespace wp12_finedustCheck.Logics
{
    public class Commons
    {
        // MySQL용
        public static readonly string myConnString = "Server=localhost;" +
                                                    "Port=3306;" +
                                                    "Database=miniproject;" +
                                                    "Uid=root;" +
                                                    "Pwd=12345;";

        // 메트로 다이얼로그창을 위한 정적 메서드
        public static async Task<MessageDialogResult> ShowMessageAsync(string title, string message,
            MessageDialogStyle style = MessageDialogStyle.Affirmative)
        {
            return await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(title, message, style, null);
        }
    }
}
