using ListModule.Models;
using ListModule.ViewModels;
using Prism.Common;
using Prism.Regions;
using System.Windows.Controls;

namespace ListModule.Views
{
    /// <summary>
    /// PersonDetailView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PersonDetailView : UserControl
    {
        public PersonDetailView()
        {
            InitializeComponent();
            //RegionContext.GetObservableContext(this).PropertyChanged += PersonDetailView_PropertyChanged;
        }

        private void PersonDetailView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var context = (ObservableObject<object>)sender;
            var selectedPerson = (Person)context.Value;
            (DataContext as PersonDetailViewModel).SelectedPerson = selectedPerson;
        }
    }
}
