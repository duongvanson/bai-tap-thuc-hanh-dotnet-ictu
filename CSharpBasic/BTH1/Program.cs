using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    class Program
    {
        static void showHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static int tinhTong(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}",a, b, a+b);
            return a + b;
        }
        static void giaiPhuongTrinhBac2(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("PT Vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("PT Vô nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình có nghiệm kép: {0}", (double)-b/c);
                }
            }
            else
            {
                var delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phương trình có nghiệm kép: {0}", (double)-b / (2 * a));
                }
                else
                {
                    Console.WriteLine("Phương trình có 2 nghiệm.");
                    Console.WriteLine("\tx1= {0}", (-b - Math.Sqrt(delta)) / (double)(2 * a));
                    Console.WriteLine("\tx1= {0}", (-b + Math.Sqrt(delta)) / (double)(2 * a));
                }
            }
        }
        static void Main(string[] args)
        {
            showHelloWorld();
            tinhTong(5, 10);
            giaiPhuongTrinhBac2(0, 0, 1);
            //frmDemo frm = new frmDemo();
            //frm.Show();
            Console.ReadKey();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDemo());
        }
    }
}
