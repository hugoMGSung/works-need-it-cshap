using Prism.Mvvm;
using Prism.Commands;
using System;
using TutorialPrismApp.Core;

namespace Modules.ViewModels
{
    public class TabViewModel : BindableBase
    {
        IApplicationCommands _applicationCommands;

        string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        bool _canUpdate = true;
        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { SetProperty(ref _canUpdate, value); }
        }

        string _updatedText;
        public string UpdateText
        {
            get { return _updatedText; }
            set { SetProperty(ref _updatedText, value); }
        }

        public DelegateCommand UpdateCommand { get; private set; }

        public TabViewModel(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);
            _applicationCommands.SaveCommand.RegisterCommand(UpdateCommand);
        }

        private void Update()
        {
            UpdateText = $"Updated: {DateTime.Now}";
        }
    }
}
