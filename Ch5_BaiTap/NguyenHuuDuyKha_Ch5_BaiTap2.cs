/*Ch5_BT2: Viết chương trình nhập vào một số nguyên dương rồi in ra tất cả các ước số của số đó.
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
    class NguyenHuuDuyKha_Ch5_BaiTap2
    {
        static void Main()
        {
            //khai báo biến và input
            Console.Write("Nhap vao 1 so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            //tính và output

            //Định nghĩ ước số: i là ước số của n nếu n chia hết cho i
            //ví dụ: 8 chia hết cho 1,2,4,8, cho nên ước của 8 là tập hợp bao gòm {1,2,4,8}

            Console.Write($"Uoc so {n} la: ");
            for (int i = 1; i <= n; i++)// i <= n vì lấy luôn chính nó
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine();
        }
    }
}
