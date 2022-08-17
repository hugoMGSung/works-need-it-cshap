using ReactiveUI;
using System;
using System.Reactive;
using System.Reactive.Linq;

namespace NewReactiveApp.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        string result;
        public string Result
        {
            get => result;
            set => this.RaiseAndSetIfChanged(ref result, value);
        }

        string username;
        public string UserName
        {
            get => username;
            set => this.RaiseAndSetIfChanged(ref username, value);
        }

        string password;
        public string Password
        {
            get => password;
            set => this.RaiseAndSetIfChanged(ref password, value);
        }

        string address;
        public string Address
        {
            get => address;
            set => this.RaiseAndSetIfChanged(ref address, value);
        }

        string phone;
        public string Phone
        {
            get => phone;
            set => this.RaiseAndSetIfChanged(ref phone, value);
        }

        public ReactiveCommand<Unit, Unit> RegisterCommand { get; }

        public MainViewModel()
        {
            RegisterCommand = ReactiveCommand.CreateFromObservable(ExecuteRegisterCommand);
        }

        private IObservable<Unit> ExecuteRegisterCommand()
        {
            Result = $"Hello, {UserName} Registration Success";
            return Observable.Return(Unit.Default);
        }
    }
}
