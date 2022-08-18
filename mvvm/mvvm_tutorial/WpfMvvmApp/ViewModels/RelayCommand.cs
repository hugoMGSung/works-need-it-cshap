using System;
using System.Windows.Input;

namespace WpfMvvmApp
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> execute;         // View에서 넘어온 Command를 실행하는 대리자
        private readonly Predicate<T> canExecute;   // View에서 넘어온 Command를 실행할수 있는지 확인 대리자

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke((T)parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute.Invoke((T)parameter);
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            // RelayCommand 실행명령은 null일 수 없음
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<T> execute) : this(execute, null) {  }
    }
}
