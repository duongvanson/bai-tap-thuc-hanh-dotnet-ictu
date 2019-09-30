//Created 30-09-2019 by duongson.dev

using System;

namespace GiaiPhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("\tPT vo so nghiem");
                else Console.WriteLine("\tPT vo nghiem");
            }
            else
            {
                Console.WriteLine("\tPT co nghiem duy nhat: {0} ",-b/a);
            }
            Console.ReadKey();
        }
    }
}
