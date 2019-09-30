//Created 01-10-2019 by duongson.dev
using System;

namespace BaiToanChoGa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHO - GA");
            for (int cho = 1; cho < 25; cho++)
            {
                for (int ga = 0; ga < 36; ga++)
                {
                    if (cho * 4 + ga * 2 == 100 && cho + ga == 36)
                    {
                        Console.WriteLine("{0} - {1}", cho, ga);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
