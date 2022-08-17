using Caliburn.Micro;
using MySql.Data.MySqlClient;
using SecondCaliburnApp.Helpers;
using SecondCaliburnApp.Models;
using System;
using System.Linq;
using System.Security;
using System.Threading;

namespace SecondCaliburnApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHaveDisplayName
    {
        public override string DisplayName { get; set; }

        string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        string lastName;

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public string FullName
        {
            get => $"{LastName} {FirstName}"; //string.Format("{0} {1}", FirstName, LastName);
        }

        public ShellViewModel()
        {
            DisplayName = "Second Caliburn App";
            //FirstName = "MyungGun";

            People = new BindableCollection<PersonModel>();
            InitCombobox();
            //People.Add(new PersonModel { LastName = "Gates", FirstName = "Bill" });
            //People.Add(new PersonModel { LastName = "Jobs", FirstName = "Steve" });
            //People.Add(new PersonModel { LastName = "Musk", FirstName = "Ellen" });
        }

        private void InitCombobox()
        {
            People.Add(new PersonModel { LastName = "", FirstName = "선택" });
            using (MySqlConnection conn = new MySqlConnection(Commons.STRCONNSTRING))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Commons.SELECTPEOPLEQUERY, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var temp = new PersonModel
                    {
                        FirstName = reader["firstname"].ToString(),
                        LastName = reader["lastname"].ToString()
                    };
                    People.Add(temp);
                }
            }

            SelectedPerson = People.Where(v => v.FirstName.Contains("선택")).First();
        }

        // 콤보박스 사람 리스트
        public BindableCollection<PersonModel> People { get; set; }

        PersonModel selectedPerson;

        public PersonModel SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                this.LastName = selectedPerson.LastName;
                this.FirstName = selectedPerson.FirstName;
                NotifyOfPropertyChange(() => SelectedPerson);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public bool CanClearName
        {
            get => !(string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName));
        }

        public void ClearName()
        {
            this.FirstName = this.LastName = string.Empty;            
        }

        public void LoadPageOne()
        {  // UserControl FirstChildView
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {   // UserControl SecondChildView
            ActivateItem(new SecondChildViewModel());
        }
    }
}
