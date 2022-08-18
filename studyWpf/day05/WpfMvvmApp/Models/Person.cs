using System;
using WpfMvvmApp.Helpers;

namespace WpfMvvmApp.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string email;
        public string Email
        {
            get { return email; } // get => email; 과 동일
            set
            {
                if (!Commons.IsValidEmail(value))  // value -> email 오류!!
                    throw new Exception("Invalid Email");
                else
                    email = value;
            }
        }

        public DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                var result = Commons.CalcAge(value);
                if (result > 135 || result < 0)
                    throw new Exception("Invalid Date");
                else
                    date = value;
            }
        }
        public bool IsBirthday { 
            get {
                return DateTime.Now.Month == date.Month &&
                    DateTime.Now.Day == date.Day;
            }
        }
        public bool IsAdult { 
            get {
                return Commons.CalcAge(date) > 18;
            } 
        }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }
    }
}
