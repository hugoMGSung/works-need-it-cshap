using System;
using WpfMvvmApp.Helpers;

namespace WpfMvvmApp.Models
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (!Commons.IsValidEmail(value))
                    throw new Exception("Invalid email");
                else
                    email = value;
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set
            {
                var result = Commons.CalcAge(value);
                if (result > 135 || result < 0)
                    throw new Exception("Invalid date");
                else
                    date = value;
            }
        }

        public string Zodiac { get { return Commons.CalcZodiac(date); } }
        public string ChnZodiac { get { return Commons.CalcChnZodiac(date); } }

        public bool IsBirthday
        {
            get
            {
                return DateTime.Now.Year == Date.Year && 
                    DateTime.Now.Month == Date.Month &&
                    DateTime.Now.Day == Date.Day;
            }
        }

        public bool IsAdult
        {
            get
            {
                return Commons.CalcAge(date) > 18;
            }
        }

        #region 생성자

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }

        #endregion
    }
}
