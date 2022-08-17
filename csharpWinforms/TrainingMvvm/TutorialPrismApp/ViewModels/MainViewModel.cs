using Prism.Commands;
using Prism.Mvvm;
using System;
using TutorialPrismApp.Core;

namespace TutorialPrismApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        string title = "Prism Unity Application";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        public MainViewModel(IApplicationCommands applicationCommands)
        {
            ApplicationCommands = applicationCommands;
        }

        //bool isEnabled;
        //public bool IsEnabled
        //{
        //    get { return isEnabled; }
        //    set
        //    {
        //        SetProperty(ref isEnabled, value);
        //        ExecuteCommand.RaiseCanExecuteChanged();
        //    }
        //}

        //string updateText;
        //public string UpdateText
        //{
        //    get { return updateText; }
        //    set { SetProperty(ref updateText, value); }
        //}

        //public DelegateCommand ExecuteCommand { get; private set; }

        //public DelegateCommand ObservesPropertyCommand { get; private set; }

        //public DelegateCommand ObservesCanExecuteCommand { get; private set; }

        //public DelegateCommand<string> ExecuteGenericCommand { get; private set; }

        //public MainViewModel() {
        //    ExecuteCommand = new DelegateCommand(Execute, CanExecute);

        //    ObservesPropertyCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => IsEnabled);

        //    ObservesCanExecuteCommand = new DelegateCommand(Execute).ObservesCanExecute(() => IsEnabled);

        //    ExecuteGenericCommand = new DelegateCommand<string>(ExecuteGeneric).ObservesCanExecute(() => IsEnabled);
        //}

        //private void ExecuteGeneric(string param)
        //{
        //    UpdateText = param;
        //}

        //private bool CanExecute()
        //{
        //    return IsEnabled;
        //}

        //private void Execute()
        //{
        //    UpdateText = $"Updated: {DateTime.Now}";
        //}
    }
}
