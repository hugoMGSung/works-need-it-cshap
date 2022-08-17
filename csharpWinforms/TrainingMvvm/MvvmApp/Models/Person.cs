using MvvmApp.Helpers;
using System;

namespace MvvmApp.Models
{
    public class Person
    {
        public string FirstName { get; set; } // table상 필드
        public string LastName { get; set; } // table상 필드

        string email;  // table상 필드
        public string Email
        {
            get { return email; }
            set
            {
                if (Commons.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid Email");
            }
        }

        DateTime date;  // table상 필드
        public DateTime Date
        {
            get { return date; }
            set
            {
                var result = Commons.CalcAge(value); // 나이
                if (result > 150 || result < 0)
                    throw new Exception("Invalid Age");
                else
                    date = value;
            }
        }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }

        public bool IsBirthDay  // 추가 속성
        {
            get
            {
                return DateTime.Now.Month == Date.Month &&
                    DateTime.Now.Day == Date.Day;
            }
        }

        public bool IsAdult  // 추가 속성
        {
            get
            {
                return Commons.CalcAge(Date) > 18;
            }
        }

        public string ChnZodiac
        {
            get
            {
                return Commons.GetChineseZodiac(Date);
            }
        }
    }
}
