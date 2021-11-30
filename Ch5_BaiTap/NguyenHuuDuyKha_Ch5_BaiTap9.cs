using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap9
    {
        static void Main()
        {
            Console.Write("Nhap vao chieu cao n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 )
            {
                //chạy từ trên dọc xuống
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)// j<=i == i <= n
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Nhap n > 0 ");
            }
        }
    }
}
