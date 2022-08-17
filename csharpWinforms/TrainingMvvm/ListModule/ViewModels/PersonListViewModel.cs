using ListModule.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;

namespace ListModule.ViewModels
{
    public class PersonListViewModel : BindableBase, INavigationAware
    {
        ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        IRegionManager _regionManager;
        IRegionNavigationJournal _journal;

        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }

        public DelegateCommand GoForwardCommand { get; set; }

        public PersonListViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();

            GoForwardCommand = new DelegateCommand(GoForward, CanGoForward);
        }

        private void PersonSelected(Person person)
        {
            var parameters = new NavigationParameters();
            parameters.Add("person", person);

            if (person != null)
                _regionManager.RequestNavigate("ContentRegion", "PersonDetailView", parameters);
        }

        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = string.Format("First {0}", i),
                    LastName = string.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            _journal = navigationContext.NavigationService.Journal;
            GoForwardCommand.RaiseCanExecuteChanged();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        private void GoForward()
        {
            _journal.GoForward();
        }

        private bool CanGoForward()
        {
            return _journal != null && _journal.CanGoForward;
        }
    }
}
