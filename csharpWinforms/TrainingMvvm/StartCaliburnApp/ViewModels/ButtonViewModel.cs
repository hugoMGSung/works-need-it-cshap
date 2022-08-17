using Caliburn.Micro;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StartCaliburnApp.ViewModels
{
    public class ButtonViewModel : Conductor<object> // Conductor<IScreen>.Collection.OneActive
    {
        public void TestButton()
        {
            MessageBox.Show("TestButton Clicked!");
        }

        public void TestButton0(object sender)
        {
            if (!(sender is Button btn)) return;
            MessageBox.Show($"TestButton0 : {btn.Content}");
        }

        public void HelloClicked1(MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                MessageBox.Show($"HelloClicked1 : {e.ButtonState.ToString()}");
            e.Handled = true;
        }

        public void HelloClicked2(object sender, MouseButtonEventArgs e)
        {
            //var btn = sender as Button;
            if (e.ChangedButton == MouseButton.Left && sender is Button btn)
                MessageBox.Show($"HelloClicked2 : {btn.Name}, {e.ButtonState.ToString()}");
            e.Handled = true;
        }

        public ICommand ButtonTest => new RelayCommand<object>(ButtonTestRun, o => o is Button);

        private void ButtonTestRun(object obj)
        {
            if (!(obj is Button btn)) return;
            MessageBox.Show($"ButtonTestClick : {btn.Name}, {btn.Content}");
        }

        public ICommand ButtonClick => new RelayCommand<object>(ButtonClickRun, o => o is Button);

        private void ButtonClickRun(object obj)
        {
            if (!(obj is Button btn)) return;
            MessageBox.Show($"ButtonClick : {btn.Content}");
        }
    }
}
