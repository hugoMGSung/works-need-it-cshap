using NewReactiveApp.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using System.Reactive.Disposables;

namespace NewReactiveApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainView : ReactiveContentPage<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();
            InitReactiveUI();
        }

        private void InitReactiveUI()
        {
            ViewModel = new MainViewModel();

            // 바인딩 설정
            // Note: We have to use WhenActivated here, since we need to dispose the
            // bindings on XAML-based platforms, or else the bindings leak memory.
            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, x => x.UserName, x => x.UserName.Text)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, x => x.Password, x => x.Password.Text)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, x => x.Address, x => x.Address.Text)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, x => x.Phone, x => x.Phone.Text)
                    .DisposeWith(disposable);
                this.BindCommand(ViewModel, x => x.RegisterCommand, x => x.Register)
                    .DisposeWith(disposable);
                this.Bind(ViewModel, x => x.Result, x => x.Result.Text)
                    .DisposeWith(disposable);
            });
        }
    }
}
