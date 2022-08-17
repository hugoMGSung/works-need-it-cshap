using System;

namespace Property
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";

        public DateTime Birthday { get; set; } = new DateTime(1900, 1, 1);

        public string PhoneNumber { get; set; } = "010-0000-0000";

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo origin = new BirthdayInfo();
            Console.WriteLine($"{origin.Name}, {origin.Birthday} 출생");
            Console.WriteLine($"{origin.Age}세");

            BirthdayInfo info = new BirthdayInfo
            {
                Name = "박서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"{info.Name}, {info.Birthday} 출생");
            Console.WriteLine($"{info.Age}세");

            var myIns = new { Name = "성명건", Home = "창원" };
            Console.WriteLine($"{myIns.Name} / {myIns.Home}");
            //
            var b = new { Subject = "수학", Scores = new int[] {99, 88, 77} };
            Console.WriteLine($"{b.Subject}");
            foreach (var item in b.Scores)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
