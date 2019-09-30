//Created 01-10-2019 by duongson.dev
using System;

namespace SoChinhPhuong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Max number 10^5
            //SCP là số mà căn của nó là một số tự nhiên & SCP không âm.
            Console.Write("Number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("NO");
                Console.ReadKey();
                return;
            }
            int temp = (int)Math.Sqrt(number);
            if (temp * temp == number)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
