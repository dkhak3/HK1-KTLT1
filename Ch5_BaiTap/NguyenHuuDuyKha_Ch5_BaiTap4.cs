/*Ch5_BT4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chính phương hay không?
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
    class NguyenHuuDuyKha_Ch5_BaiTap4
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            //tính và output
            while (n <= 0)
            {
                Console.WriteLine("Nhap sai, yeu cau nhap lai.");
                Console.Write("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            }

            //số chính phương là một số tự nhiên có căn bậc hai cũng là một số tự nhiên.
            //số chính phương là ví dụ: 2^2 = 4

            bool kTra = false;
            for (int i = 1; i <= n; i++)
            {
                if (i * i == n)// hoặc Math.sqrt(i) == n
                {
                    kTra = true;              
                }
            }

            if (kTra == true)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so chinh phuong");
            }
        }
    }
}
