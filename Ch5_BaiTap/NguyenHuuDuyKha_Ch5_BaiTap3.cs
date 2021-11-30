/*Ch5_BT3: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số nguyên tố hay không? 
 * Name: Nguyễn Hữu Duy Kha
 * Date: 30/11/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap3
    {
        static void Main()
        {
            //Số nguyên tố là tập hợp những số tự nhiên chỉ chia hết cho 1 và chính nó.

            //khai báo biến và input
            Console.Write("Nhap vao mot so nguyen duong: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //processing and output
            if ( n < 2) //Số nguyên tố nhỏ nhất và có 1 chữ số là số 2
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
            else
            {
                bool Ktra = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % 2 == 0)
                    {
                        Ktra = false;

                    }
                }
                if (Ktra)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                }
                else
                {
                    Console.WriteLine($"{n} khong phai la so nguyen to");
                }
            }
        }
    }
}
