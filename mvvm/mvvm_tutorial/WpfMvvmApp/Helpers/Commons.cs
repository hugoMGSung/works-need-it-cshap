using System;
using System.Text.RegularExpressions;

namespace WpfMvvmApp.Helpers
{
    public class Commons
    {
        // 이메일 주소 검승 메서드
        public static bool IsValidEmail(string email)
        {
            // Regular-Expression(정규표현식)
            return Regex.IsMatch(email,
                @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-z
A-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
            // or personar95@naver.com
            /*string[] parts = email.Split('@');
            if (parts.Length != 2) return false;
            return !(parts[1].Split('.').Length < 2); */
        }

        // 나이 계산 메서드
        public static int CalcAge(DateTime value)
        {
            int middle = DateTime.Now.Month < value.Month || DateTime.Now.Month == value.Month &&
            DateTime.Now.Day < value.Day
                ? DateTime.Now.Year - value.Year - 1
                : DateTime.Now.Year - value.Year;
            return middle;
        }

        // 별자리 확인메서드
        public static string CalcZodiac(DateTime date)
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

        // 12지(띠) 계산 메서드
        public static string CalcChnZodiac(DateTime date)
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
