//Created 30-09-2019 by duongson.dev

using System;

namespace HinhTron
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            do
            {
                Console.Write("Ban kinh = ");
                R = Convert.ToDouble(Console.ReadLine());
                if (R < 0)
                {
                    Console.WriteLine("\tNhap ban kinh > 0.");
                }
            } while (R < 0);
            Console.WriteLine("\tChu vi: {0:0.00}", 2.0*R*Math.PI);
            Console.WriteLine("\tDien tich: {0:0.00}", R*R*Math.PI);
            Console.ReadKey();
        }
    }
}
