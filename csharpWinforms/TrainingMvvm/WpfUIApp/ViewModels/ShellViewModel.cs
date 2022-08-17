using Caliburn.Micro;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Markup;
using WpfUIApp.Commons;
using WpfUIApp.Models;

namespace WpfUIApp.ViewModels
{
    public class ShellViewModel : Conductor<object> // Screen
    {
        private string _firstName = "MyungGun";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            /* People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            //People.Add(new PersonModel { FirstName = "Bill", LastName = "Gates" });
            //People.Add(new PersonModel { FirstName = "Steve", LastName = "Jobs" });
            //People.Add(new PersonModel { FirstName = "Hugo MG", LastName = "Sung" }); */
            using (SqlConnection conn = new SqlConnection(StaticInfos.CONNSTR))
            {
                conn.Open();
                string strQuery = InnerQuerys.GETPEOPLE_QRY;
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var temp = new PersonModel { FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString() };
                    People.Add(temp);
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                LastName = _selectedPerson.LastName;
                FirstName = _selectedPerson.FirstName;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
                return false;
            else
                return true;
        }

        public void ClearText()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
