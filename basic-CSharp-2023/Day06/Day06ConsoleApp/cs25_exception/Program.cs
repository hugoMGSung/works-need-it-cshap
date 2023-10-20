using System;

namespace cs25_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            try
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex) // 모르겠다 싶으면 Exception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 예외가 발생하더라도 무조건 처리해야 되는 로직
                // file 객체 close
                // db 연결 close
                // 네트워크 소켓 close
                Console.WriteLine("계속가요");
            }

            try
            {
                DivideTest(array[2], 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine("프로그램 종료!!!");

            //try
            //{
            //    Console.WriteLine("TEST TEST");
            //    throw new Exception("커스텀 예외!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

        private static void DivideTest(int v1, int v2)
        {
            try
            {
                Console.WriteLine(v1 / v2);
            }
            catch
            {
                // 현재 메서드에 예외처리하지 않고 메서드를 호출한 곳에서 예외처리한다.
                throw new Exception("DivideTest 메서드에서 예외가 발생!"); 
            }
            
        }
    }
}
