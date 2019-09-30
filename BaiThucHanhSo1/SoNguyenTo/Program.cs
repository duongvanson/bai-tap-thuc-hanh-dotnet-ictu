//Created 01-10-2019 by duongson.dev
using System;

namespace SoNguyenTo
{
    class Program
    {
        static bool kiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (kiemTraSoNguyenTo(number))
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
