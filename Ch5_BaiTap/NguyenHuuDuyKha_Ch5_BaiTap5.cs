/*Ch5_BT5: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số hoàn hảo hay không? 
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
    class NguyenHuuDuyKha_Ch5_BaiTap5
    {
        static void Main()
        {
            Console.Write("Nhap vao so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Nhap sai, yeu cau nhap lai.");
                Console.Write("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            }

            //ví dụ: Số hoàn hảo : tổng các ước của nó ( trừ chính nó ra ) = nó
            //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
            //=> 6 là một con số hoàn hảo

            //tính và output

            int sum = 0;
            for (int i = 1; i < n; i++)//i < n chứ ko <= n vì bỏ nó ra
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so hoan hao");
            }


        }
    }
}
