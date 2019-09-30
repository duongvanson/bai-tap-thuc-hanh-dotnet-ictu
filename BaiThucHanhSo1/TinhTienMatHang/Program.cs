//Created 01-10-2019 by duongson.dev
using System;

namespace TinhTienMatHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Don gia = ");
            double donGia = Convert.ToDouble(Console.ReadLine());
            Console.Write("So luong = ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            double thanhTien = donGia * soLuong;
            if (thanhTien > 100)
            {
                thanhTien = thanhTien - (thanhTien * 3 / 100);
            }
            Console.WriteLine("\tTong tien tra: {0}", thanhTien);
            Console.ReadKey();
        }
    }
}
