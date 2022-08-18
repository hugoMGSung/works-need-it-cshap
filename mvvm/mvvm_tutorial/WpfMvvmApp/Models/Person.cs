using System;
using WpfMvvmApp.Helpers;

namespace WpfMvvmApp.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string email;
        public string Email {
            get => email;
            set
            {
                if (Commons.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid email");
            }
        }

        private DateTime date;
        public DateTime Date {
            get => date;
            set
            {
                var result = Commons.CalcAge(value);
                if (result > 140 || result < 0)
                    throw new Exception("Invalid birthday");
                else
                    date = value;
            }
        }
        public bool IsBirthday => DateTime.Now.Month == Date.Month && DateTime.Now.Day == Date.Day;
        public bool IsAdult => Commons.CalcAge(date) > 18;
        public string Zodiac => Commons.CalcZodiac(date);
        public string ChnZodiac => Commons.CalcChnZodiac(date);

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }
    }
}
