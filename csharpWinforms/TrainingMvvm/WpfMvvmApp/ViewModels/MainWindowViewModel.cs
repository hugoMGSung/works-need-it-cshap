using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfMvvmApp.Helpers;
using WpfMvvmApp.Models;

namespace WpfMvvmApp.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Input용 필드

        private string inFirstName;
        private string inLastName;
        private string inEmail;
        private DateTime? inDate;

        #endregion

        #region Output용 필드

        private string outFirstName;
        private string outLastName;
        private string outFullName;
        private string outEmail;
        private string outDate;

        private string outAdult;
        private string outBirthday;
        private string outZodiac;
        private string outChnZodiac;

        #endregion

        public string InFirstName
        {
            get => inFirstName;
            set
            {
                inFirstName = value;
                RaisePropertyChanged("InFirstName");
            }
        }

        public string InLastName
        {
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChanged("InLastName");
            }
        }

        public string InEmail
        {
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChanged("InEmail");
            }
        }

        public DateTime? InDate
        {
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChanged("InDate");
            }
        }

        public string OutFirstName
        {
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChanged("OutFirstName");
            }
        }

        public string OutLastName
        {
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChanged("OutLastName");
            }
        }

        public string OutFullName
        {
            get => outFullName;
            set
            {
                outFullName = $"{outLastName} {outFirstName}";
                RaisePropertyChanged("OutFullName");
            }
        }

        public string OutEmail
        {
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChanged("OutEmail");
            }
        }
        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged("OutDate");
            }
        }

        public string OutAdult
        {
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged("OutAdult");
            }
        }

        public string OutBirthday
        {
            get => outBirthday;
            set
            {
                outBirthday = value;
                RaisePropertyChanged("OutBirthday");
            }
        }

        public string OutZodiac
        {
            get => outZodiac;
            set
            {
                outZodiac = value;
                RaisePropertyChanged("OutZodiac");
            }
        }

        public string OutChnZodiac
        {
            get => outChnZodiac;
            set
            {
                outChnZodiac = value;
                RaisePropertyChanged("OutChnZodiac");
            }
        }

        private ICommand proceedCommand;

        public ICommand ProceedCommand => proceedCommand ?? (proceedCommand = new RelayCommand<object>(
                o => Proceed(), o => !string.IsNullOrEmpty(inEmail) && 
                                    !string.IsNullOrEmpty(inDate.ToString()) &&
                                    !string.IsNullOrEmpty(inFirstName) && 
                                    !string.IsNullOrEmpty(inLastName) ));

        public async void Proceed()
        {
            try
            {
                DateTime date = inDate ?? DateTime.Now;
                Person person = new Person(inFirstName, inLastName, inEmail, date);

                await Task.Run(() => OutFirstName = person.FirstName);
                await Task.Run(() => OutLastName = person.LastName);
                await Task.Run(() => OutEmail = person.Email);
                await Task.Run(() => OutDate = person.Date.ToShortDateString());
                await Task.Run(() => OutBirthday = $"{person.IsBirthday}");
                await Task.Run(() => OutAdult = $"{person.IsAdult}");
                await Task.Run(() => OutZodiac = person.Zodiac);
                await Task.Run(() => OutChnZodiac = person.ChnZodiac);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }
    }
}
