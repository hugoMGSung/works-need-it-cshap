using Caliburn.Micro;
using WpfCaliburnPageApp.Models;

namespace WpfCaliburnPageApp.ViewModels
{
    public class MainViewModel : Conductor<object> // Screen // PropertyChangedBase, IHaveDisplayName 모두 포함
    {
        private string firstName = "MyungGun";
        private string lastName = "Sung";
        private BindableCollection<Person> people = new BindableCollection<Person>();
        private Person selectedPerson;

        public Person SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                LastName = selectedPerson.LastName;
                FirstName = selectedPerson.FirstName;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName); // !
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName); // !
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public string FullName
        {
            get => $"{LastName} {FirstName}";
        }

        public BindableCollection<Person> People
        {
            get => people;
            set => people = value;
        }

        public MainViewModel()
        {
            DisplayName = "Second Caliburn App";

            People.Add(new Person { Idx = 1, FirstName = "Bill", LastName = "Gates" });
            People.Add(new Person { Idx = 2, FirstName = "Steve", LastName = "Jobs" });
            People.Add(new Person { Idx = 3, FirstName = "MyungGun", LastName = "Sung" });
        }

        public void ClearName()
        {
            FirstName = LastName = string.Empty;
        }

        public bool CanClearName
        {
            get => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
        }

        public void LoadFirstChild()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }

        public void LoadSecondChild()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }
    }
}
