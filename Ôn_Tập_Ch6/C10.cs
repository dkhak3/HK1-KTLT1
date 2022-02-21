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

            Console.WriteLine("Nhập vào n: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Vui lòng nhập lại.");
            }
            else
            {
                for (int i = 1; i <= n; i++)//tăng i rồi chuyền xuống if, if chuyền xuống dưới kia
                {                           //i tăng cho tới khi = n nhập từ bàn phím
                    if (Check(i) == true) //chuyền i trên đây xuống cho i dưới 
                                            //NÊN mới gán check(i)
                    {
                        dem++;
                    }

                }
                Console.WriteLine($"Đếm các số hoàn hảo nhỏ hơn hoặc bằng N = {dem}");
            }
        }

        static bool Check(double n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sum = 0;
      
            //ví dụ: Số hoàn hảo : tổng các ước của nó ( trừ chính nó ra ) = nó
            //6 : 1 + 2 + 3 => 1 + 2 + 3 = 6
            //=> 6 là một con số hoàn hảo

            for (int i = 1; i < n; i++)//n đc nhận từ check(i) ở trên
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }
    }
}
