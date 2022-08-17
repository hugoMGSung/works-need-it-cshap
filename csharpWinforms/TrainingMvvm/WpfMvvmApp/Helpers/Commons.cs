using System;
using System.Text.RegularExpressions;

namespace WpfMvvmApp.Helpers
{
    class Commons
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
            // or
            /*string[] parts = email.Split('@');
            if (parts.Length != 2) return false;
            return !(parts[1].Split('.').Length < 2); */
        }

        internal static int CalcAge(DateTime value)
        {
            int middle;
            if (DateTime.Now.Month < value.Month || DateTime.Now.Month == value.Month && DateTime.Now.Day < value.Day)
                middle = DateTime.Now.Year - value.Year - 1;
            else
                middle = DateTime.Now.Year - value.Year;

            return middle;

            /*
            if (middle > 135 || middle < 0)
                return false;
            else
                return true; */
        } 

        internal static string CalcZodiac(DateTime date)
        {
            string result;
            if (date.Month <= 1 && date.Day <= 20)
                result = "염소자리";
            else if (date.Month <= 2 && date.Day <= 18)
                result = "물병자리";
            else if (date.Month <= 3 && date.Day <= 20)
                result = "물고기자리";
            else if (date.Month <= 4 && date.Day <= 20)
                result = "양자리";
            else if (date.Month <= 5 && date.Day <= 20)
                result = "황소자리";
            else if (date.Month <= 6 && date.Day <= 21)
                result = "쌍둥이자리";
            else if (date.Month <= 7 && date.Day <= 22)
                result = "게자리";
            else if (date.Month <= 8 && date.Day <= 22)
                result = "사자자리";
            else if (date.Month <= 9 && date.Day <= 22)
                result = "처녀자리";
            else if (date.Month <= 10 && date.Day <= 23)
                result = "천칭자리";
            else if (date.Month <= 11 && date.Day <= 22)
                result = "전갈자리";
            else
                result = "사수자리";

            return result;
        }

        internal static string CalcChnZodiac(DateTime date)
        {
            int remainder = date.Year % 12;

            switch (remainder)
            {
                case 4:
                    return "쥐띠";
                case 5:
                    return "소띠";
                case 6:
                    return "호랑이띠";
                case 7:
                    return "토끼띠";
                case 8:
                    return "용띠";
                case 9:
                    return "뱀띠";
                case 10:
                    return "말띠";
                case 11:
                    return "양띠";
                case 0:
                    return "원숭이띠";
                case 1:
                    return "닭띠";
                case 2:
                    return "개띠";
                case 3:
                    return "돼지띠";
                default:
                    return "잡띠";
            }
        }
    }
}
