using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NaverMovieFinder
{
    //INotifyPropertyChanged는 선언적인 인터페이스로서
    //<Button Content="Test" Command="{Binding GetMessage}" />로 바인딩 했을 때
    //GetMassage에 해당하는  GetMessageCommand : ICommand 가 바인딩되도록 함
    class MainViewModel : INotifyPropertyChanged
    {
        private NaverMovieModel VmModel = new NaverMovieModel();

        public MainViewModel()
        {
            this.VmModel.OnMovieLoadCompleted += VmModel_OnMovieLoadCompleted;
        }

        public event EventHandler OnMovieCompleted;

        void VmModel_OnMovieLoadCompleted(object sender, EventArgs e)
        {
            if (this.OnMovieCompleted != null)
            {
                this.OnMovieCompleted(sender, e);
            }
        }

        private bool _canTestExecuted = true;

        private ICommand _getMessageCommand;
        public ICommand SearchMovie
        {
            get
            {
                if (this._getMessageCommand == null)
                {
                    this._getMessageCommand = new GetMessageCommand(this);
                }
                return this._getMessageCommand;
            }
        }

        public List<Movie> AllMovies
        {
            get { return this.VmModel.AllMovies; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public class GetMessageCommand : ICommand
        {
            private MainViewModel _viewModel;
            public GetMessageCommand(MainViewModel viewModel)
            {
                this._viewModel = viewModel;
                this._viewModel.PropertyChanged += _viewModel_PropertyChanged;
            }

            //이벤트 핸들러(실행가능 상태가 변경되었는지 판단하는 이벤트: 현재는 항상 true만을 리턴함으로 의미 없음)
            void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                if (CanExecuteChanged != null)
                    CanExecuteChanged(this, EventArgs.Empty);
            }

            public bool CanExecute(object parameter)
            {
                //활성화(true), 비활성화(false)
                return _viewModel._canTestExecuted;
            }

            public event EventHandler CanExecuteChanged;

            //버튼을 클릭하면 자동으로 실행되는 부분
            public void Execute(object parameter)
            {
                string keyword = parameter.ToString();
                this._viewModel.VmModel.SearchMovie(keyword);
                //DateTime ddate = new DateTime(2014, 2, 25, 15, 48, 0);
                //if (DateTime.Now.CompareTo(ddate) > 0)
                //{
                //   this._viewModel._canTestExecuted = false;
                //}
                //this._viewModel._canTestExecuted = false;
                if (this._viewModel.PropertyChanged != null)
                {
                    this._viewModel.PropertyChanged(this._viewModel, new PropertyChangedEventArgs("AllMovies"));
                }
            }
        }
    }
}
