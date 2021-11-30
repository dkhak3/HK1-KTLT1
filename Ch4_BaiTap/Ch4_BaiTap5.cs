/*Ch4_BT5: Viết chương trình nhập vào giờ phút giây (hh:mm:ss) và số giây thêm vào. Tính và in ra kết quả dưới dạng (hh:mm:ss) mới sau khi cộng số giây thêm vào
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class Ch4_BaiTap5
    {
        static void Main()
        {
            //khai báo biến và input
            int gio = 0;
            int phut = 0;
            int giay = 0;
            int giayThem = 0;
            int giayTong = 0;
            int gioMoi = 0;
            int phutMoi = 0;
            int giayMoi = 0;

            Console.Write("Nhap vao gio: ");
            gio = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao phut: ");
            phut = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao giay: ");
            giay = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao giay them: ");
            giayThem = int.Parse(Console.ReadLine());

            //tính
            giayTong = gio * 3600 + phut * 60 + giay + giayThem;
            gioMoi = giayTong / 3600;
            phutMoi = (giayTong % 3600) / 60;
            giayMoi = giayTong % 60;
            
            //output
            Console.WriteLine($"So gio phut giay moi la: {gioMoi:00}:{phutMoi:00}:{giayMoi:00} ");

        }

    }
}

