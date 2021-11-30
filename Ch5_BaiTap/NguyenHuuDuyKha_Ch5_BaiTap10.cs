using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap10
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao chieu cao n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 1; j < 2*n; j++)
                    {
                        if(Math.Abs(n - j ) < i)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Nhap n > 0");
            }
        }
    }
}
