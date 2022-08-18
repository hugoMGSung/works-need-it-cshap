using System;
using System.Windows;
using System.Windows.Input;
using WpfMvvmApp.Models;

namespace WpfMvvmApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string inFirstName;
        private string inLastName;
        private string inEmail;
        private DateTime? inDate;

        private string outFirstName;
        private string outLastName;
        private string outEmail;
        private string outDate;
        private string outBirthday;

        private string outAdult;
        private string outZodiac; // 별자리
        private string outChnZodiac;    // 12지

        public string OutAdult
        {
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged("OutAdult");
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

        public string InFirstName
        {
            get => inFirstName;
            //set => inFirstName = value;
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

        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged("OutDate");
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

        public string OutBirthday
        {
            get => outBirthday;
            set
            {
                outBirthday = value;
                RaisePropertyChanged("OutBirthday");
            }
        }

        ICommand clickCommand;

        public ICommand ClickCommand => clickCommand ?? (clickCommand = new RelayCommand<object>(o => Click(), o => IsClick()));

        private bool IsClick()
        {
            return (!string.IsNullOrEmpty(InLastName) && 
                    !string.IsNullOrEmpty(InFirstName) && 
                    !string.IsNullOrEmpty(InEmail) && 
                    !string.IsNullOrEmpty(InDate.ToString())); // ! 입력안하면 버튼클릭 안됨!! 
        }

        private void Click()
        {
            try
            {
                DateTime date = InDate ?? DateTime.Now;
                Person person = new Person(InFirstName, InLastName, InEmail, date);

                OutFirstName = person.FirstName;
                OutLastName = person.LastName;
                OutEmail = person.Email;
                OutDate = person.Date.ToString("yyyy-MM-dd");
                OutBirthday = person.IsBirthday.ToString();

                OutAdult = person.IsAdult.ToString();  // 210903 추가
                OutZodiac = person.Zodiac;
                OutChnZodiac = person.ChnZodiac;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
            }
        }
    }
}
