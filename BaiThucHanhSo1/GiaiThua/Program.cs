//Created 01-10-2019 by duongson.dev
using System;

namespace GiaiThua
{
    class Program
    {
        static long tinhGiaiThua(int n)
        {
            long gt = 1;
            if (n == 0) return 1;
            return n * tinhGiaiThua(n-1);
        }

        static void Main(string[] args)
        {
            Console.Write("Number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", number, tinhGiaiThua(number));
            Console.ReadKey();
        }
    }
}
