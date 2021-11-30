using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap14
    {
        static void Main()
        {
            int n = 0;
            int doi = 0;
            
            Console.WriteLine("Nhap vao so nguyen n: ");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                doi = doi * 10 + n % 10;

                n /= 10;// trừ đi 10 cho mỗi lần chạy

                //ví dụ:
                //1234  1234  1234  1234    1234
                //0     4     43    432     4321
                //1234  123   12    1       0
            }
            Console.WriteLine($"So nguoc lai cua n la {doi}");
            
        }
    }
}
