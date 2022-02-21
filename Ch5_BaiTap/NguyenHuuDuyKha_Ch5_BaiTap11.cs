using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class NguyenHuuDuyKha_Ch5_BaiTap11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 0;
            int n = 0;
            double S = 0;
            double sc = 0;
            double sl = 0;
            Console.WriteLine("Nhập x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào số lần lặp:");
            n = Convert.ToInt32(Console.ReadLine());

            //Câu a
            for (int i = 0; i <= n; i++)
            {
                S += Math.Pow(x, i);
            }
            Console.WriteLine($"Câu a. S = {S}");

            //Câu b
            for (int j = 0; j <= n; j++)
            {
                if (j % 2 != 0)
                {

                    sl += Math.Pow(-x, j);
                }
                else
                {
                    sc += Math.Pow(x, j);
                }

            }
            Console.WriteLine($"Câu b. S= {sc + sl}");
        }
    }
}
