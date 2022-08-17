using System;

namespace EnumApp
{
    class MainApp
    {
        enum DialogResult
        {
            YES = 10,
            NO = 20,
            CANCEL = 30,
            CONFIRM = 40,
            OK = 50
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(DialogResult.OK);
            //Console.WriteLine((int)DialogResult.OK);
            DialogResult result = DialogResult.YES;
            if (result == DialogResult.YES)
            {
                Console.WriteLine("YES를 선택했습니다.");
            }
        }
    }
}
