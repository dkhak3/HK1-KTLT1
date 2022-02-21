/*Ch_BT10 : Viết chương trình đếm các số hoàn hảo nhỏ hơn hoặc bằng N, với N là số nguyên dương được nhập vào từ bàn phím.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 19/12/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BT10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double n = 0;
            int dem = 0;

            Console.WriteLine("Nhập vào số nguyên dương: ");
            n = double.Parse(Console.ReadLine());

            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (CheckSoHoanHao(i) == true)
                    {
                        dem++;// đếm các số hoàn hảo nhỏ hơn hoặc = n
                    }
                }
                Console.WriteLine($"Các số hoàn hảo từ 1 đến {n} = {dem}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương");
            }

        }
        public static bool CheckSoHoanHao(double n)
        {
            int tong = 0;
            //Số hoàn hảo : tổng các ước của nó ( trừ chính nó ra ) = nó
            //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
            //=> 6 là một con số hoàn hảo

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    tong = tong + i;//nếu là ước số thì cộng vào tong
                }
            }
            //So sánh tổng ước số với số đã cho để tìm ra số hoàn hảo
            if (tong == n)
            {
                return true;
            }
            return false;
        }
    }
}
