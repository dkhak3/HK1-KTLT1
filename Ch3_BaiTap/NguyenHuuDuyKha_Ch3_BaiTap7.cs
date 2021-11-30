/*Ch3_BT7 :Viết chương trình nhập vào số giây từ 0 đến 86399, đổi số giây nhập vào thành dạng "gio:phut:giay", mỗi thành phần là một số nguyên có 2 chữ số.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 16/11/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BaiTap7
{
    class NguyenHuuDuyKha_Ch3_BaiTap7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo biến
            int giaynhap = 0;//nhập số giây
            int giay = 0;//giá trị giây được chuyển từ giaynhap
            int phut = 0;//giá trị phút được chuyển từ giaynhap
            int gio = 0;//giá trị giờ được chuyển từ giaynhap


            //input
            Console.Write("Nhập vào số giây: ");
            giaynhap = int.Parse(Console.ReadLine());

            //processing
            gio = giaynhap / 3600;
            phut = (giaynhap % 3600)/60;
            giay = giaynhap % 60;

            //output
            Console.WriteLine($"giây nhập được đổi thành: {gio :00}:{phut :00}:{giay :00}");
        }
    }
}
