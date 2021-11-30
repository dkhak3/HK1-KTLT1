/*Ch4_BT13: Viết chương trình nhập vào tháng và năm, in ra tháng đó có bao nhiêu ngày.
	Hướng dẫn:  Nếu là tháng 1, 3, 5, 7, 8, 10, 12 thì có 31 ngày
	Nếu là tháng 4, 6, 9, 11 thì có 30 ngày
	Nếu là tháng 2 và là năm nhuận thì có 29 ngày ngược lại 28 ngày
	Năm nhuận là năm chia hết cho 4 và không chia hết cho 100; hoặc chia hết cho 400.

 * Name: Nguyễn Hữu Duy Kha
 * Date: 21/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BaiTap
{
    class NguyenHuuDuyKha_Ch4_BaiTap13
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao thang: ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao nam: ");
            int nam = int.Parse(Console.ReadLine());

            //tính và output
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"thang {thang} co 31 ngay");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"thang {thang} co 30 ngay");
                    break;

                case 2:    if ((nam % 4 == 0  && nam % 100 != 0) || (nam % 400 == 0) )
                    {
                        Console.WriteLine($"thang {thang} la nam nhuan co 29 ngay");
                    }
                    else
                    {
                        Console.WriteLine($"thang {thang} la nam khong nhuan co 28 ngay");
                    }
                    break;

                default:
                    Console.WriteLine("Nhap thang hoac nam sai");
                    break;
            }
        }
    }
}
