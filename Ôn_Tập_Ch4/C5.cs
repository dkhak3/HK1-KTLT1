using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch4
{
    class C5
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao gio");
            int gio = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao phut");
            int phut = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao giay");
            int giay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao giayThem");
            int giayThem = int.Parse(Console.ReadLine());

            int giayTong = gio * 3600 + phut * 60 + giay + giayThem;
            int gioMoi = giayTong / 3600;
            int phutMoi = (giayTong % 3600) / 60;
            int giayMoi = giayTong % 60;

            Console.WriteLine($"So gio phut giay moi la: {gioMoi:00}:{phutMoi:00}:{giayMoi:00} ");

        }
    }
}
