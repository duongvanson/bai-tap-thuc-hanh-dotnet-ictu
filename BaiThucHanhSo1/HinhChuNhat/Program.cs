//Created 30-09-2019 by duongson.dev

using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double chieuDai, chieuRong;
            do
            {
                Console.Write("Chieu dai = ");
                chieuDai = Convert.ToDouble(Console.ReadLine());
                Console.Write("Chieu rong = ");
                chieuRong = Convert.ToDouble(Console.ReadLine());
                if (chieuDai < 0 || chieuRong < 0)
                {
                    Console.WriteLine("\tChieu dai & chieu rong > 0.");
                }
            } while (chieuDai < 0 || chieuRong < 0);
            Console.WriteLine("\tChu vi: {0}", chieuDai+chieuRong);
            Console.WriteLine("\tDien tich: {0}", chieuDai*chieuRong);
            Console.ReadKey();
        }
    }
}
