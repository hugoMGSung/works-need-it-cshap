using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numindex = 3;
            Elv(numindex);
            Control(numindex);
        }

        static void Control(int numindex)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 19);
                ConsoleKeyInfo k = Console.ReadKey();

                Console.Clear();
                Elv(numindex);

                switch (k.Key)
                {
                    case
                        ConsoleKey.UpArrow:
                        numindex--;
                        if (numindex < 0) numindex = 0;
                        break;
                    case
                        ConsoleKey.DownArrow:
                        numindex++;
                        if (numindex > 3) numindex = 3;
                        break;
                    case
                        ConsoleKey.Enter:

                        if (numindex == 3) // 1층
                        {
                            Console.SetCursorPosition(20, 18);
                            Console.Write("└─────────────────┘");
                            Console.SetCursorPosition(20, 19);
                            Console.Write("가려고 하는 층 수를 입력해 주세요.");
                        }
                        else if (numindex == 2) // 2층
                        {
                            Console.SetCursorPosition(20, 13);
                            Console.Write("└─────────────────┘");
                            Console.SetCursorPosition(20, 14);
                            Console.Write("가려고 하는 층 수를 입력해 주세요.");
                        }
                        else if (numindex == 1) // 3층
                        {
                            Console.SetCursorPosition(20, 9);
                            Console.Write("└─────────────────┘");
                            Console.SetCursorPosition(20, 10);
                            Console.Write("가려고 하는 층 수를 입력해 주세요.");
                        }
                        else if (numindex == 0) // 4층
                        {
                            Console.SetCursorPosition(20, 5);
                            Console.Write("└─────────────────┘");
                            Console.SetCursorPosition(20, 6);
                            Console.Write("가려고 하는 층 수를 입력해 주세요.");
                        }
                        ElvButton(numindex);
                        Console.Clear();
                        break;
                }
                Elv(numindex);
            }
        }
        static void Elv(int numindex)
        {
            string[] number = { "4F", "3F", "2F", "1F" };

            Console.SetCursorPosition(0, 0);
            Console.Write("┌─────────────────┐");
            Console.SetCursorPosition(0, 1);
            Console.Write("│                 │");
            for (int i = 0; i < number.Length; i++)
            {
                Console.SetCursorPosition(0, 2 + (i * 2)); // 2 4 6 8
                Console.Write("│                 │");
                Console.SetCursorPosition(0, 5 + (i * 4)); // 5 9 13 17
                Console.Write("│                 │");
                Console.SetCursorPosition(0, 10 + (i * 2)); // 10 12 14 16
                Console.Write("│                 │");

                Console.SetCursorPosition(0, 3 + (i * 4)); // 3 7 11
                if (numindex == i)
                {
                    Console.Write("│        ");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(number[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("       │");
                }
                else
                {
                    Console.Write("│        {0}       │", number[i]);
                }
            }
            Console.SetCursorPosition(0, 18);
            Console.Write("└─────────────────┘");
        }
        static void ElvButton(int numindex)
        {
            Elv(numindex);
            ConsoleKeyInfo k = Console.ReadKey();
            if (numindex == 3) // 1층
            {
                if (k.Key == ConsoleKey.D1) // 1층 입력 했을 때
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 18);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 19);
                    Console.Write(" 현재 층입니다.");
                    Elv(numindex);
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D2) // 2층 입력 했을 때
                {
                    numindex = numindex - 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 2층에 도착했습니다.");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D3) // 3층 입력 했을 때
                {
                    numindex = numindex - 2;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 14);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 3층에 도착했습니다.");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:02초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D4) // 4층 입력 했을 때
                {
                    numindex = numindex - 3;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 14);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 10);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:02초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 5);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 4층에 도착했습니다.");
                    Console.SetCursorPosition(40, 6);
                    Console.Write("[0:03초]");
                    ElvButton(numindex);
                }
            }
            if (numindex == 2) // 2층
            {
                if (k.Key == ConsoleKey.D1) // 1층 입력 했을 때
                {
                    numindex = numindex + 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 18);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 1층에 도착했습니다.");
                    Console.SetCursorPosition(40, 19);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D2) // 2층 입력 했을 때
                {
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 14);
                    Console.Write(" 현재 층입니다.");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D3) // 3층 입력 했을 때
                {
                    numindex = numindex - 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 3층에 도착했습니다.");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D4) // 4층 입력 했을 때
                {
                    numindex = numindex - 2;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 10);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 5);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 4층에 도착했습니다.");
                    Console.SetCursorPosition(40, 6);
                    Console.Write("[0:02초]");
                    ElvButton(numindex);
                }
            }
            if (numindex == 1) // 3층
            {
                if (k.Key == ConsoleKey.D1) // 1층 입력 했을 때
                {
                    numindex = numindex + 2;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 14);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 18);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 1층에 도착했습니다.");
                    Console.SetCursorPosition(40, 19);
                    Console.Write("[0:02초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D2) // 2층 입력 했을 때
                {
                    numindex = numindex + 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 2층에 도착했습니다.");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D3) // 3층 입력 했을 때
                {
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 10);
                    Console.Write(" 현재 층입니다.");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D4) // 4층 입력 했을 때
                {
                    numindex = numindex - 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 5);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 4층에 도착했습니다.");
                    Console.SetCursorPosition(40, 6);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
            }
            if (numindex == 0) // 4층
            {
                if (k.Key == ConsoleKey.D1) // 1층 입력 했을 때
                {
                    numindex = numindex + 3;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 10);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 14);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:02초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 18);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 1층에 도착했습니다.");
                    Console.SetCursorPosition(40, 19);
                    Console.Write("[0:03초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D2) // 2층 입력 했을 때
                {
                    numindex = numindex + 2;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 10);
                    Console.Write("    이   동   중");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:01초]");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 13);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 2층에 도착했습니다.");
                    Console.SetCursorPosition(40, 14);
                    Console.Write("[0:02초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D3) // 3층 입력 했을 때
                {
                    numindex = numindex + 1;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 9);
                    Console.Write("└─────────────────┘");
                    Console.Write(" 3층에 도착했습니다.");
                    Console.SetCursorPosition(40, 10);
                    Console.Write("[0:01초]");
                    ElvButton(numindex);
                }
                else if (k.Key == ConsoleKey.D4) // 4층 입력 했을 때
                {
                    Console.Clear();
                    Elv(numindex);
                    Console.SetCursorPosition(20, 5);
                    Console.Write("└─────────────────┘");
                    Console.SetCursorPosition(20, 6);
                    Console.Write(" 현재 층입니다.");
                    ElvButton(numindex);
                }
            }
        }
    }
}
