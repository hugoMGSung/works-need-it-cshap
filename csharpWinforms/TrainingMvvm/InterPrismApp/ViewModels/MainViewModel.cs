using Prism.Mvvm;

namespace InterPrismApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainViewModel() { }
    }
}
