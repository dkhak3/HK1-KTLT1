/*Ch4_BT10: Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0, với a, b, c nhập vào từ bàn phím.
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
    class NguyenHuuDuyKha_Ch4_BaiTap10
    {
        static void Main()
        {
            //khai báo biến
            int a, b, c;

            //input
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            //tính và output
            if (a == 0) // giai pt bac nhat
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine("Phuong trinh khong co nghiem");
                }
                else
                {
                    float x = (float)-c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
            }
            else // giai pt bac hai ( a != 0 )
            {
                int delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh khong co nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + (float)(-b) / (2 * a)));
                }
                else //(delta > 0)
                {
                    float x1 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    float x2 = (float)(-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Nghiem phuong trinh la:");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
    }
}
